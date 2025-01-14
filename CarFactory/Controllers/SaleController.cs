using MediatR;
using Microsoft.AspNetCore.Mvc;
using Modules.CarFactory.Core.Dto;
using Modules.CarFactory.Core.Features.CreateSale;
using Modules.CarFactory.Core.Features.GetPercentOfModels;
using Modules.CarFactory.Core.Features.GetTotalVolume;
using Modules.CarFactory.Core.Features.GetTotalVolumeByDistributionId;

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

        [HttpGet]
        [Route("totalVolumes")]
        public async Task<IActionResult> GetTotalVolume()
        {
            var totalVolumeRequest = new GetTotalVolumeRequest();
            var response = await _mediator.Send(totalVolumeRequest);
            return Ok(response);
        }

        [HttpGet]
        [Route("totalVolumesByDistributionId")]
        public async Task<IActionResult> GetTotalVolumeByDistributionId(int distributionId)
        {
            var totalVolumeRequest = new GetTotalVolumeByDistributionIdRequest(distributionId);
            var response = await _mediator.Send(totalVolumeRequest);
            return Ok(response);
        }

        [HttpGet]
        [Route("modelPercent")]
        public async Task<IActionResult> GetPercentOfModels()
        {
            var totalVolumeRequest = new GetPercentOfModelsRequest();
            var response = await _mediator.Send(totalVolumeRequest);
            return Ok(response);
        }
    }
}
