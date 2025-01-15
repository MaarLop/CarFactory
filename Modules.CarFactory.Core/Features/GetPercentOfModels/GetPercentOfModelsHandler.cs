using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Modules.CarFactory.Core.Abstractions;

namespace Modules.CarFactory.Core.Features.GetPercentOfModels
{
    internal class GetPercentOfModelsHandler : IRequestHandler<GetPercentOfModelsRequest, GetPercentOfModelsResponse>
    {
        private ISaleRepository _repository;

        public GetPercentOfModelsHandler(ISaleRepository repository)
        {
            _repository = repository;
        }
        public Task<GetPercentOfModelsResponse> Handle(GetPercentOfModelsRequest request, CancellationToken cancellationToken)
        {
            var salesByModel = _repository.GetPercentForModels();
            return Task.FromResult(new GetPercentOfModelsResponse(salesByModel));
        }
    }
}
