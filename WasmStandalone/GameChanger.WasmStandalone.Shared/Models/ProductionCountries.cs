using System.Text.Json.Serialization;

namespace GameChanger.WasmStandalone.Shared.Models;

public class ProductionCountries
{
    [JsonPropertyName("iso_3166_1")]
    public string? LanguageCode { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
