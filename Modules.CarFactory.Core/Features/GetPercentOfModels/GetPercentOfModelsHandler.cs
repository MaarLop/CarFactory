﻿using MediatR;
using Modules.CarFactory.Core.Abstractions;

namespace Modules.CarFactory.Core.Features.GetPercentOfModels
{
    internal class GetPercentOfModelsHandler : IRequestHandler<GetPercentOfModelsRequest, GetPercentOfModelsResponse>
    {
        private readonly ISaleRepository _repository;

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