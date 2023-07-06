using VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer
{
    public class BreedListData : AbstractContainerWithModelsAndStringCount
    {
        [JsonPropertyName("breed")]
        public required Breed[] Models { get; set; }
        public override Breed[] GetModels()
        {
            return Models;
        }
    }
}
