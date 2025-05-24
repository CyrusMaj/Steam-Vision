public class ReleaseDateDto
{
    public int Id { get; set; }
    public boolean ComingSoon { get; set; }
    public string Date { get; set; }

    public SteamGameDto SteamGame { get; set; }
}