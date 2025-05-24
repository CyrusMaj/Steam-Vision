public class PublisherDto
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<SteamGameDto> SteamGames { get; set; }
}