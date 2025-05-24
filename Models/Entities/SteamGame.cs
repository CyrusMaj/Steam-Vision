public class SteamGame
{
    public int Id { get; set; } // Primary Key
    public string AppId { get; set; }
    public string Name { get; set; }

    public string Type { get; set; }
    public string RequiredAge { get; set; }
    public string IsFree { get; set; }
    public string DetailedDescription { get; set; }
    public string AboutTheGame { get; set; }
    public string ShortDescription { get; set; }
    public string SupportedLanguages { get; set; }

    // Navigation properties
    public Price Price { get; set; }
    public ICollection<Platform> Platforms { get; set; }
    public ICollection<Genre> Genres { get; set; }
    public ICollection<Tag> Tags { get; set; }
    public ICollection<Category> Categories { get; set; }
    public Metacritic Metacritic { get; set; }
    public ReleaseDate ReleaseDate { get; set; }
    public ICollection<Developer> Developers { get; set; }
    public ICollection<Publisher> Publishers { get; set; }
}
