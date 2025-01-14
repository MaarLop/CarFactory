using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Models;

namespace Modules.CarFactory.Core.Extensions
{
    public static class SaleExtensions
    {
        public static SaleModel ToModel(this Sale sale) => new SaleModel(sale.Id, sale.CarId, sale.DistributionCenterId, sale.DateTime);
    }
}
