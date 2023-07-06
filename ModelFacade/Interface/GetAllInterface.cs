using VetmanagerApiGateway.DTO.ModelContainer.Model;

namespace VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface GetAllInterface<T> where T : AbstractModel
    {
        Task<T[]> All();
    }
}
