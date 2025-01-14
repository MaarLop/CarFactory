namespace Modules.CarFactory.Core.Domain
{
    public class Sale(int carId, int distributionCenterId)
    {
        public int Id { get; set; }
        public int CarId { get; set; } = carId;
        public int DistributionCenterId { get; set; } = distributionCenterId;
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
    }
}
