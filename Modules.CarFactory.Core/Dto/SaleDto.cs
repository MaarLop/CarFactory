using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Core.Dto
{
    public class SaleDto
    {
        public int CarId { get; set; }
        public int DistributionCenterId { get; set; }
    }
}
