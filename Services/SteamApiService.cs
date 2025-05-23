using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using SteamVision.Data;

namespace SteamVision.Services
{
    public class SteamApiService
    {
        private readonly HttpClient _httpClient;
        private readonly AppDbContext _context;
        private readonly string _steamApiKey = "YOUR_STEAM_API_KEY";

        public SteamApiService(HttpClient httpClient, AppDbContext context)
        {
            _httpClient = httpClient;
            _context = context;
        }

        public async Task<string> GetGameListAsync()
        {
            string url = $"https://api.steampowered.com/ISteamApps/GetAppList/v2/";
            var response = await _httpClient.GetStringAsync(url);
            return response;
        }

        public async Task<string> GetGameDetailsAsync(string appId)
        {
            string url = $"https://store.steampowered.com/api/appdetails?appids={appId}";
            var response = await _httpClient.GetStringAsync(url);
            return response;
        }

        public async Task<List<SteamGameDto>> GetAllGameDetailsAsync()
        {
            string url = "https://api.steampowered.com/ISteamApps/GetAppList/v2/";
            var response = await _httpClient.GetStringAsync(url);

            var steamAppList = JsonSerializer.Deserialize<SteamAppList>(response, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            var steamGames = steamAppList?.AppList?.Apps;

            if (steamGames == null)
                return new List<SteamGameDto>();

            var steamGameDtos = steamGames.Select(game => new SteamGameDto
            {
                AppId = game.AppId,
                Name = game.Name
            }).ToList();

            return steamGameDtos;
        }

        public async Task<int> CacheAllGamesToDatabaseAsync()
        {
            var steamGames = await GetAllGameDetailsAsync();

            // Avoid inserting duplicates
            var existingAppIds = _context.SteamGames.Select(g => g.AppId).ToHashSet();

            // Filter new DTOs
            var newGameDtos = steamGames
                .Where(g => !existingAppIds.Contains(g.AppId))
                .ToList();

            if (newGameDtos.Count == 0)
                return 0;

            // Convert DTOs to Entities
            var newGameEntities = newGameDtos.Select(dto => new SteamGame
            {
                AppId = dto.AppId,
                Name = dto.Name
            }).ToList();

            _context.SteamGames.AddRange(newGameEntities);
            return await _context.SaveChangesAsync(); // Returns the number of records added
        }
    }
}
