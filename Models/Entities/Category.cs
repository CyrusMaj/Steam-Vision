public class Category
{
    public int Id { get; set; }
    public string Category { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}