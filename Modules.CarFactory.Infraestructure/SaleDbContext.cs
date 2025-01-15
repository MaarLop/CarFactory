using Microsoft.EntityFrameworkCore;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Domain.Car;

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
                new Sport(),
                new Offroad(),
                new Sedan(),
                new Suv()
            });
        }
    }
}