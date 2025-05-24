public class SteamGameDto
{
    public string AppId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public string RequiredAge { get; set; }
    public string IsFree { get; set; }
    public string DetailedDescription { get; set; }
    public string AboutTheGame { get; set; }
    public string ShortDescription { get; set; }
    public string SupportedLanguages { get; set; }
    public PriceDto Price { get; set; }
    public MetacriticDto Metacritic { get; set; }
    public ReleaseDateDto ReleaseDate { get; set; }

    public List<string> Platforms { get; set; }
    public List<string> Categories { get; set; }
    public List<string> Genres { get; set; }
    public List<string> Tags { get; set; }
    public List<string> Developers { get; set; }
    public List<string> Publishers { get; set; }
}
