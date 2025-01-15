using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Features.CreateSale;
using Modules.CarFactory.UT.Mothers;
using Moq;

namespace Modules.CarFactory.UT.Handlers
{
    public class CreateSaleHandlerShould : CreateSaleTest
    {
        [Fact]
        public async Task CreateASaleWithCorrectParamsReturnsTheCreatedObject()
        {
            var createSaleRequest = new CreateSaleRequest(1, 1);
            
            var response = _saleHandler.Handle(createSaleRequest, new CancellationToken());

            Assert.NotNull(response);
            await Assert.IsType<Task<CreateSaleResponse>>(response);
        }
        [Theory]
        [InlineData(-1, 1)]
        [InlineData(0, 1)]
        [InlineData(1, -1)]
        [InlineData(5, 0)]
        public async Task CreateASaleWithInvalidIdsThrowAnArgumentException(int carId, int distributionCenterId)
        {
            var createSaleRequest = new CreateSaleRequest(carId, distributionCenterId);

            await Assert.ThrowsAsync<ArgumentException>(() => _saleHandler.Handle(createSaleRequest, new CancellationToken()));
        }
    }
}
