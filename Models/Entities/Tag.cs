public class Tag
{
    public int Id { get; set; }
    public string Tag { get; set; }

    public ICollection<SteamGame> SteamGames { get; set; }
}