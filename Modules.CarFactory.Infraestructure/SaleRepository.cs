using Microsoft.EntityFrameworkCore;
using Modules.CarFactory.Core.Abstractions;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Infraestructure
{
    public class SaleRepository : ISaleRepository
    {
        private readonly SaleDbContext _context;

        public SaleRepository(SaleDbContext context)
        {
            _context = context;
        }
        public Sale Save(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale;
        }
    }
}
