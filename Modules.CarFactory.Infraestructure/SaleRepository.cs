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

        public object GetPercentForModels()
        {
            var sales = _context.Sales;
            var totalVentas = sales.Count();

            return sales
                .AsEnumerable()
                .Join(
                    inner: _context.Cars,
                    outerKeySelector: s => s.CarId,
                    innerKeySelector: c => c.Id,
                    resultSelector: (s, c) => new { Sale = s, Car = c } // Anonymous type
                )
                .GroupBy(x => nameof(x.Sale.Car))
                .ToDictionary(
                        sg => sg.Key,
                        sg => (double)sg.Count() / totalVentas * 100
                    );
        }

        public decimal GetTotalVolume(int? distributionId = null)
        {
            return _context.Sales
                .Where(s => distributionId == null || s.DistributionCenterId == distributionId)
                .Join(
                    inner: _context.Cars,
                    outerKeySelector: s => s.CarId,
                    innerKeySelector: c => c.Id,
                    resultSelector: (s, c) => new { Sale = s, Car = c } // Anonymous type
                )
                .AsEnumerable() // Force client-side evaluation
                .Sum(joinedData => joinedData.Car.Price);
        }

        public Sale Save(Sale sale)
        {
            _context.Sales.Add(sale);
            _context.SaveChanges();
            return sale;
        }
    }
}
