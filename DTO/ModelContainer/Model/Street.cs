using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer.Model
{
    public class Street : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("city_id")]
        public required string CityId { get; set; }
        [JsonPropertyName("type")]
        public required string Type { get; set; }
    }
}
