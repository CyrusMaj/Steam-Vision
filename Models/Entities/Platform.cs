public class Platform
{
    public int Id { get; set; }
    public string Name { get; set; }
    public boolean Windows { get; set; }
    public boolean Linux { get; set; }
    public boolean Mac { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}
