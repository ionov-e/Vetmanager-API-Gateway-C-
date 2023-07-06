using VetmanagerApiGateway.DTO.ModelContainer;
using VetmanagerApiGateway.DTO.ModelContainer.Model;
using VetmanagerApiGateway.ModelFacade.Interface;
using VetmanagerApiGateway.PathUri;

namespace VetmanagerApiGateway.ModelFacade
{
    public class PetTypeFacade : AbstactModelFacade, ModelFacadeInterface, GetByIdInterface<PetType>, GetAllInterface<PetType>
    {
        public PetTypeFacade(ApiGateway apiGateway) : base(apiGateway)
        {
        }

        public static AccessibleModelPathUri ModelPathUri => AccessibleModelPathUri.petType;

        public async Task<PetType> ById(int id) => await ApiGateway.GetModel<PetType, PetTypeData>(ModelPathUri, id);

        public async Task<PetType[]> All() => await ApiGateway.GetModels<PetType, PetTypeListData>(ModelPathUri);
    }
}
