namespace Modules.CarFactory.Core.Domain
{
    public class Sale
    {
        public int Id { get; set; }

        public int CarId { get; set; }

        public int DistributionCenterId { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;

        public virtual Car.Car Car { get; set; }

        public Sale(int carId, int distributionCenterId)
        {
            if (carId <= 0)
            {
                throw new ArgumentException("CardId must be greater than 0");
            }
            if (distributionCenterId <= 0)
            {
                throw new ArgumentException("CardId must be greater than 0");
            }
            CarId = carId;
            DistributionCenterId = distributionCenterId;
        }
    }
}