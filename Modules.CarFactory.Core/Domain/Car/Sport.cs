namespace Modules.CarFactory.Core.Domain.Car
{
    public class Sport : Car
    {
        public Sport()
        {
            Price = 18200 * 1.07m;
            Model = nameof(Sport);
        }
    }
}