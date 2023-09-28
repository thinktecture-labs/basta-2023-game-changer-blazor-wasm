using System.Text.Json.Serialization;

namespace GameChanger.WasmStandalone.Shared.Models;

public class SpokenLanguages
{
    [JsonPropertyName("english_name")]
    public string? EnglishName { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
