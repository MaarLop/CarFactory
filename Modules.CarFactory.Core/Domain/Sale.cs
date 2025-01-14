using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.CarFactory.Core.Domain
{
    public class Sale
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int DistributionCenterId { get; set; }
    }
}
