using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.Core.Abstractions
{
    public interface ISaleRepository
    {
        Sale Save(Sale sale);
    }
}
