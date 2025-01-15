using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Models;

namespace Modules.CarFactory.UT.Mothers
{
    public static class SaleMother
    {
        public static Sale Default =>
            new Sale(1, 1);

        public static Sale WithId(this Sale sale, int id)
        {
            sale.Id = id;
            return sale;
        }
    }
}
