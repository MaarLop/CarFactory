using Microsoft.EntityFrameworkCore;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Infraestructure
{
    public class SaleDbContext : DbContext
    {
        public DbSet<Sale> Sales { get; set; }

        public SaleDbContext(DbContextOptions<SaleDbContext> optionsBuilder) : base(optionsBuilder)
        {
        }
    }
}
