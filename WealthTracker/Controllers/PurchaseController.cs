using Microsoft.AspNetCore.Mvc;
using WealthTracker.DTOs;
using WealthTracker.Services;

namespace WealthTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchasesController : ControllerBase
    {
        // TODO: Authentication and authorization
        private static readonly Guid TemporaryUserId =
            Guid.Parse("11111111-1111-1111-1111-111111111111");

        private readonly IPurchaseService _purchaseService;
        public PurchasesController(IPurchaseService purchaseService)
        {
            _purchaseService = purchaseService;
        }

        // Endpoints here
        [HttpPost]
        public async Task<ActionResult<PurchaseResponseDto>> CreateAsync([FromBody] CreatePurchaseDto dto)
        {
            try
            {
                var purchase = await _purchaseService.CreateAsync(dto, TemporaryUserId);

                var response = new PurchaseResponseDto
                {
                    Id = purchase.Id,
                    Ticker = dto.Ticker.Trim().ToUpperInvariant(),
                    Date = purchase.Date,
                    UnitPrice = purchase.UnitPrice,
                    Quantity = purchase.Quantity,
                    Taxes = purchase.Taxes
                };

                return Ok(response);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}