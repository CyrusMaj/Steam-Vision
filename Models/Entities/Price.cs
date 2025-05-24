public class Price
{
    public int Id { get; set; }
    public string Currency { get; set; }
    public int Initial { get; set; }
    public int Final { get; set; }
    public int DiscountPercent { get; set; }

    public int SteamGameId { get; set; }
    public SteamGame SteamGame { get; set; }
}
