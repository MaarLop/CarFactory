namespace Modules.CarFactory.Core.Models
{
    public class SaleModel
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DistributionCenterId { get; set; }
        public DateTime DateTime { get; set; }

        public SaleModel(int id, int carId, int distributionCenterId, DateTime dateTime)
        {
            Id = id;
            CarId = carId;
            DistributionCenterId = distributionCenterId;
            DateTime = dateTime;
        }
    }
}