using VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface GetByIdInterface<T> where T : AbstractModel
    {
        Task<T> ById(int id);
    }
}
