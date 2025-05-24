public class TagDto
{
    public int Id { get; set; }
    public string Tag { get; set; }

    public List<SteamGameDto> SteamGames { get; set; }
}