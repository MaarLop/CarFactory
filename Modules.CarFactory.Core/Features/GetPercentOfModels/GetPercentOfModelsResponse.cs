namespace Modules.CarFactory.Core.Features.GetPercentOfModels
{
    public class GetPercentOfModelsResponse
    {
        public Dictionary<string, decimal> SalesByModel;

        public GetPercentOfModelsResponse(Dictionary<string, decimal> salesByModel)
        {
            SalesByModel = salesByModel;
        }
    }
}