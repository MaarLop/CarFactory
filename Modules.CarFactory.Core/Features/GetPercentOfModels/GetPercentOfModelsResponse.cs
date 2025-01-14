namespace Modules.CarFactory.Core.Features.GetPercentOfModels
{
    public class GetPercentOfModelsResponse
    {
        private object salesByModel;

        public GetPercentOfModelsResponse(object salesByModel)
        {
            this.salesByModel = salesByModel;
        }
    }
}