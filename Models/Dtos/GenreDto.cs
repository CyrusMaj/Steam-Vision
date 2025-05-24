public class GenreDto
{
    public int Id { get; set; }
    public string Genre { get; set; }

    public List<SteamGameDto> SteamGames { get; set; }
}