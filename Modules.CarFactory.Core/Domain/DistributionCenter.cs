namespace Modules.CarFactory.Core.Domain
{
    public class DistributionCenter(int id, string desciption, string address)
    {
        public int Id { get; set; } = id;
        public string Description { get; set; } = desciption;
        public string Address { get; set; } = address;
    }
}
