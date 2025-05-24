public class Genre
{
    public int Id { get; set; }
    public string Genre { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}