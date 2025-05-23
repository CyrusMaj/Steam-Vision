using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using SteamVision.Services;

[Route("api/steam")]
[ApiController]
public class SteamController : ControllerBase
{
    private readonly SteamApiService _steamApiService;

    public SteamController(SteamApiService steamApiService)
    {
        _steamApiService = steamApiService;
    }

    // Fetch list of all games
    [HttpGet("games")]
    public async Task<IActionResult> GetAllGames()
    {
        var result = await _steamApiService.GetGameListAsync();
        return Ok(result);
    }
    
    // Fetch game details by app id
    [HttpGet("game-details/{appId}")]
    public async Task<IActionResult> GetGameDetails(string appId)
    {
        var result = await _steamApiService.GetGameDetailsAsync(appId);
        return Ok(result);
    }

    //Cache games to db
    [HttpPost("cache-games")]
    public async Task<IActionResult> CacheGames()
    {
        var count = await _steamApiService.CacheAllGamesToDatabaseAsync();
        return Ok(new { Message = $"{count} games cached to the database." });
    }

}
