using Modules.CarFactory.Core.Abstractions;
using Modules.CarFactory.Core.Domain;
using Modules.CarFactory.Core.Features.CreateSale;
using Modules.CarFactory.UT.Mothers;
using Moq;

namespace Modules.CarFactory.UT.Handlers
{
    public class CreateSaleTest
    {
        protected Mock<ISaleRepository> _saleRepository;
        protected CreateSaleHandler _saleHandler;

        public CreateSaleTest()
        {
            _saleRepository = new Mock<ISaleRepository>();

            _saleRepository.Setup(x => x.Save(It.IsAny<Sale>()))
                .Returns(SaleMother.Default.WithId(1));

            _saleHandler = new CreateSaleHandler(_saleRepository.Object);
        }
    }
}