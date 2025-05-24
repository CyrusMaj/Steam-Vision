public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}