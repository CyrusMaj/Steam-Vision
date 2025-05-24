public class DeveloperDto
{
    public int Id { get; set; }
    public string Developer { get; set; }

    public List<SteamGameDto> SteamGames { get; set; }
}