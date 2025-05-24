public class Developer
{
    public int Id { get; set; }
    public string Developer { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}