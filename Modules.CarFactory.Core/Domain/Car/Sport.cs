using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modules.CarFactory.Core.Domain.Car
{
    public class Sport : Car
    {
        public Sport()
        {
            Price = 18200 * 1.07m;
            Model = nameof(Sport);
        } 
    }
}
