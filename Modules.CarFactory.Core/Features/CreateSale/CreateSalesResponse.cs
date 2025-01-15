using Modules.CarFactory.Core.Models;

namespace Modules.CarFactory.Core.Features.CreateSale
{
    public class CreateSaleResponse
    {
        public SaleModel Sale;

        public CreateSaleResponse(SaleModel saleModel)
        {
            Sale = saleModel;
        }
    }
}