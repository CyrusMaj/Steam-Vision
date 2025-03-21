using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public class SteamApiService
{
    private readonly HttpClient _httpClient;
    private readonly string _steamApiKey = "YOUR_STEAM_API_KEY";

    public SteamApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
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

    public async Task<List<SteamGame>> GetAllGameDetailsAsync()
    {
        string url = "https://api.steampowered.com/ISteamApps/GetAppList/v2/";
        var response = await _httpClient.GetStringAsync(url);

        // Deserialize JSON response
        var steamAppList = JsonSerializer.Deserialize<SteamAppList>(response, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        });

        return steamAppList?.AppList?.Apps ?? new List<SteamGame>();
    }
}
