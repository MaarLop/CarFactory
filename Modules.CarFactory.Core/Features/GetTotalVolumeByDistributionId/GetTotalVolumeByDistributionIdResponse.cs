namespace Modules.CarFactory.Core.Features.GetTotalVolumeByDistributionId
{
    public class GetTotalVolumeByDistributionIdResponse
    {
        public decimal TotalVolume { get; set; }
        public int DistributionCenterId { get; set; }

        public GetTotalVolumeByDistributionIdResponse(int distributionId, decimal total)
        {
            DistributionCenterId = distributionId;
            TotalVolume = total;
        }
    }
}