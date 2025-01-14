using Microsoft.EntityFrameworkCore;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Infraestructure
{
    public class SaleDbContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Car> Cars { get; set; }

        public SaleDbContext(DbContextOptions<SaleDbContext> optionsBuilder) : base(optionsBuilder)
        {
            Cars.AddRange(new List<Car>
            {
                Car.Create(CarModel.Sport),
                Car.Create(CarModel.Offroad),
                Car.Create(CarModel.Sedan),
                Car.Create(CarModel.Suv)
            });
        }
    }
}
