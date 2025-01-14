using MediatR;
using Modules.CarFactory.Core.Abstractions;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Extensions;

namespace Modules.CarFactory.Core.Features.CreateSale
{
    internal class CreateSaleHandler : IRequestHandler<CreateSaleRequest, CreateSaleResponse>
    {
        private ISaleRepository _saleRepository;

        public CreateSaleHandler(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }
        public Task<CreateSaleResponse> Handle(CreateSaleRequest request, CancellationToken cancellationToken)
        {
            /*Here we can check if the carId and the distributionCenterId exists
             with calling the handler of eachone
             With this we can show an exception that can be showed in the response of the api like a 404*/
            var sale = new Sale(request.CarId, request.DistributionCenterId);

            _saleRepository.Save(sale);

            return Task.FromResult(new CreateSaleResponse(sale.ToModel()));
        }
    }
}
