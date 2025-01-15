namespace Modules.CarFactory.Core.Features.GetTotalVolume
{
    public class GetTotalVolumeResponse
    {
        public decimal Total { get; set; }

        public GetTotalVolumeResponse(decimal total)
        {
            Total = total;
        }
    }
}