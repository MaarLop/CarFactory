namespace Modules.CarFactory.Core.Features.GetTotalVolumeByDistributionId
{
    public class GetTotalVolumeByDistributionIdResponse
    {
        public decimal TotalVolume { get; set; }

        public GetTotalVolumeByDistributionIdResponse(decimal total)
        {
            TotalVolume = total;
        }

    }
}