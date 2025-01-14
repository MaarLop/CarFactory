using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modules.CarFactory.Core.Dto;
using Modules.CarFactory.Core.Features.CreateSale;

namespace CarFactory.Controllers
{
    [ApiController]
    [Route("api/sales")]
    public class SaleController : ControllerBase
    {
        private readonly ILogger<SaleController> _logger;
        private readonly IMediator _mediator;

        public SaleController(ILogger<SaleController> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateASaleAsync([FromBody] SaleDto sale)
        {
            var createSaleRequest = new CreateSaleRequest(sale.CarId, sale.DistributionCenterId);
            var response = await _mediator.Send(createSaleRequest);
            return Created(string.Empty, response.Sale);
        }
    }
}