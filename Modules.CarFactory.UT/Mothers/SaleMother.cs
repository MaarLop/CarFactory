using Modules.CarFactory.Core.Domain;

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