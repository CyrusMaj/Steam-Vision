public class PriceDto
{
    public int Id { get; set; }
    public string Currency { get; set; }
    public int Initial { get; set; }
    public int Final { get; set; }
    public int DiscountPercent { get; set; }

    public int SteamGameId { get; set; }
    public SteamGameDto SteamGame { get; set; }
}
