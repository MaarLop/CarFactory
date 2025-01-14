namespace Modules.CarFactory.Core.Domain
{
    public class DistributionCenter
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public DistributionCenter(int id, string desciption, string address)
        {
            Id = id;
            Description = desciption;
            Address = address;
        }
    }
}
