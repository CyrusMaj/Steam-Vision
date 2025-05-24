using System.Collections.Generic;
using System.Text.Json.Serialization;

public class SteamAppList
{
    [JsonPropertyName("applist")]
    public AppListContainer AppList { get; set; }
}

public class AppListContainer
{
    [JsonPropertyName("apps")]
    public List<SteamGame> Apps { get; set; }
}

// public class SteamGameDto
// {
//     [JsonPropertyName("appid")]
//     public string AppId { get; set; }

//     [JsonPropertyName("name")]
//     public string Name { get; set; }
// }
