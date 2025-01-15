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

        public Dictionary<string, decimal> GetPercentForModels()
        {
            var sales = _context.Sales;
            var totalVentas = sales.Count();

            return sales
                .Join(
                    inner: _context.Cars,
                    outerKeySelector: s => s.CarId,
                    innerKeySelector: c => c.Id,
                    resultSelector: (s, c) => new { Sale = s, Car = c }
                )
                .AsEnumerable()
                .GroupBy(x => x.Sale.Car.Model)
                .ToDictionary(
                        sg => sg.Key,
                        sg => (decimal)sg.Count() / totalVentas * 100
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
