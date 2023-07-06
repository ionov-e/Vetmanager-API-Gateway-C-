using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer.Model
{
    public class City : AbstractModel
    {
        [JsonPropertyName("title")]
        public required string Title { get; set; }
        [JsonPropertyName("type_id")]
        public required string? TypeId { get; set; }
    }
}
