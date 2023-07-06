using VetmanagerApiGateway.PathUri;

namespace VetmanagerApiGateway.ModelFacade.Interface
{
    internal interface ModelFacadeInterface
    {
        //static abstract AccessibleModelPathUri GetAccessibleModel();
        static abstract AccessibleModelPathUri ModelPathUri { get; }
    }
}
