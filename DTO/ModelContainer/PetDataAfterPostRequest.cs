using VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer
{
    public class PetDataAfterPostRequest : AbstractContainerWithOneModelAndIntCount
    {
        [JsonPropertyName("pet")]
        public required Pet[] Models { get; set; }
        public override Pet GetModel()
        {
            return Models[0];
        }
    }
}
