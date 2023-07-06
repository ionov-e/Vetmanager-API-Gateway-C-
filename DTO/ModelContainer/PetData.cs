using VetmanagerApiGateway.DTO.ModelContainer.Model;
using System.Text.Json.Serialization;

namespace VetmanagerApiGateway.DTO.ModelContainer
{
    public class PetData : AbstractContainerWithOneModelAndIntCount   /// TODO : Make internal later
    {
        [JsonPropertyName("pet")]
        public required Pet Model { get; set; }
        public override Pet GetModel()
        {
            return Model;
        }
    }
}
