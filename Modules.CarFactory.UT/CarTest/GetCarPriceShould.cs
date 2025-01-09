using Modules.CarFactory.Core.Domain;

namespace Modules.CarFactory.UT.CarTest
{
    public class GetCarPriceShould
    {
        [Fact]
        public void GivenASportCarWitchHasToAppyTaxesReturnsAHigherPrice()
        {
            var sportCar = Car.Create(CarModel.Sport);

            var price = sportCar.GetSellingPrice(withTaxes: true);

            Assert.True(sportCar.Price < price);
        }

        [Fact]
        public void GivenANonSportCarWitchHasToAppyTaxesReturnsTheSamePrice()
        {
            var sedanCar = Car.Create(CarModel.Sedan);

            var price = sedanCar.GetSellingPrice(withTaxes: true);

            Assert.Equal(sedanCar.Price, price);
        }

        [Fact]
        public void GivenANonSportCarWitchHasNotToAppyTaxesReturnsTheSamePrice()
        {
            var sedanCar = Car.Create(CarModel.Sedan);

            var price = sedanCar.GetSellingPrice(withTaxes: false);

            Assert.Equal(sedanCar.Price, price);
        }
    }
}