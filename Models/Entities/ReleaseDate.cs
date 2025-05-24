public class ReleaseDate
{
    public int Id { get; set; }
    public boolean ComingSoon { get; set; }
    public string Date { get; set; }

    public SteamGame SteamGame { get; set; }
}