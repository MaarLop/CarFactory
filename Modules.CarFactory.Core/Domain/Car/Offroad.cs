using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.CarFactory.Core.Domain.Car
{
    public class Offroad : Car
    {
        public Offroad()
        {
            Price = 12500;
            Model = nameof(Offroad);
        }
    }
}
