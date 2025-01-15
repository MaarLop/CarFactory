using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.CarFactory.Core.Domain.Car
{
    public class Suv : Car
    {
        public Suv()
        {
            Price = 9500;
            Model = nameof(Suv);
        }
    }
}
