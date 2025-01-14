using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Modules.CarFactory.Core.Abstractions;

namespace Modules.CarFactory.Core.Features.GetTotalVolume
{
    internal class GetTotalVolumeHandler : IRequestHandler<GetTotalVolumeRequest, GetTotalVolumeResponse>
    {
        private ISaleRepository _saleRepository;

        public GetTotalVolumeHandler(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }

        public Task<GetTotalVolumeResponse> Handle(GetTotalVolumeRequest request, CancellationToken cancellationToken)
        {
            var totalVolume = _saleRepository.GetTotalVolume();
            return Task.FromResult(new GetTotalVolumeResponse(totalVolume));
        }
    }
}
