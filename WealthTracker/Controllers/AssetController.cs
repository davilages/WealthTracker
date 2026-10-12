using Microsoft.AspNetCore.Mvc;
using WealthTracker.DTOs;
using WealthTracker.Services;

namespace WealthTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _assetService;

        public AssetsController(IAssetService assetService)
        {
            _assetService = assetService;
        }

        // endpoints aqui
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AssetResponseDto>>> GetAllAsync()
        {
            var assets = await _assetService.GetAllAsync();
            var dtos = assets.Select(a => new AssetResponseDto
            {
                Id = a.Id,
                Ticker = a.Ticker,
                Name = a.Name,
                Sector = a.Sector,
                Type = a.Type
            });
            return Ok(dtos);
        }

        // endpoints aqui
        [HttpGet("{id}")]
        public async Task<ActionResult<AssetResponseDto>> GetByIdAsync(int id)
        {
            var asset = await _assetService.GetByIdAsync(id);

            if (asset == null)
            {
                return NotFound();
            }
            else
            {
                var dto = new AssetResponseDto
                {
                    Id = asset.Id,
                    Ticker = asset.Ticker,
                    Name = asset.Name,
                    Sector = asset.Sector,
                    Type = asset.Type
                };
                return Ok(dto);
            }
        }
    }
}