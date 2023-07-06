using VetmanagerApiGateway.DTO.ModelContainer;
using VetmanagerApiGateway.DTO.ModelContainer.Model;
using VetmanagerApiGateway.ModelFacade.Interface;
using VetmanagerApiGateway.PathUri;

namespace VetmanagerApiGateway.ModelFacade
{
    public class ClientFacade : AbstactModelFacade, ModelFacadeInterface, GetByIdInterface<Client>, GetAllInterface<Client>
    {
        public ClientFacade(ApiGateway apiGateway) : base(apiGateway)
        {
        }

        public static AccessibleModelPathUri ModelPathUri => AccessibleModelPathUri.client;

        public async Task<Client> ById(int id) => await ApiGateway.GetModel<Client, ClientData>(ModelPathUri, id);

        public async Task<Client[]> All() => await ApiGateway.GetModels<Client, ClientListData>(ModelPathUri);
    }
}
