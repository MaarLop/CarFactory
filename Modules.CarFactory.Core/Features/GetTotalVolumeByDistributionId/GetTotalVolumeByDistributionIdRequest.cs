using MediatR;

namespace Modules.CarFactory.Core.Features.GetTotalVolumeByDistributionId
{
    public class GetTotalVolumeByDistributionIdRequest : IRequest<GetTotalVolumeByDistributionIdResponse>
    {
        public int DistributionCenterId { get; set; }

        public GetTotalVolumeByDistributionIdRequest(int distributionId)
        {
            DistributionCenterId = distributionId;
        }
    }
}