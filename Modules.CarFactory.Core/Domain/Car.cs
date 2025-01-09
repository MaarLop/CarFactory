using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Modules.CarFactory.Core.Domain
{
    public class Car
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public decimal Price { get; private set; }

        private Car(string model, decimal price)
        {
            Model = model;
            Price = price;
        }

        public static Car Create(string model)
        {
            var price = model switch
            {
                CarModel.Sedan => 8000,
                CarModel.Suv => 9500,
                CarModel.Offroad => 12500,
                CarModel.Sport => 18200,
                _ => throw new ArgumentException("Invalid model name")
            };

            return new Car(model, price);
        }

        public decimal GetSellingPrice(bool withTaxes)
        {
            return withTaxes && Model == CarModel.Sport ? Price * 1.07m : Price;
        }
    }
}
