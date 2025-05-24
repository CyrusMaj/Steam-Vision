public class CategoryDto
{
    public int Id { get; set; }
    public string Category { get; set; }

    public List<SteamGameDto> SteamGames { get; set; }
}