using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Modules.CarFactory.Core.Abstractions;

namespace Modules.CarFactory.Core.Features.GetTotalVolumeByDistributionId
{
    internal class GetTotalVolumeByDistributionIdHandler : IRequestHandler<GetTotalVolumeByDistributionIdRequest , GetTotalVolumeByDistributionIdResponse>
    {
        private ISaleRepository _repository;

        public GetTotalVolumeByDistributionIdHandler(ISaleRepository repository)
        {
            _repository = repository;
        }

        public Task<GetTotalVolumeByDistributionIdResponse> Handle(GetTotalVolumeByDistributionIdRequest request, CancellationToken cancellationToken)
        {
            if(request.DistributionCenterId < 1)
            {
                throw new ArgumentException("The distributionCenterId must be greater then 0");
            }
            var total = _repository.GetTotalVolume(request.DistributionCenterId);

            return Task.FromResult(new GetTotalVolumeByDistributionIdResponse(request.DistributionCenterId, total));
        }
    }
}
