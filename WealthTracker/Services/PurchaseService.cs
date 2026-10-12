using WealthTracker.Repositories;
using WealthTracker.Entities;
using WealthTracker.DTOs;

namespace WealthTracker.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IPurchaseRepository _repository;
        private readonly IAssetService _assetService;
        private readonly IBrapiService _brapiService;
        private readonly IPositionService _positionService;
        public PurchaseService(IPurchaseRepository repository, IAssetService assetService, IBrapiService brapiService, IPositionService positionService)
        {
            _repository = repository;
            _assetService = assetService;
            _brapiService = brapiService;
            _positionService = positionService;
        }
        public async Task<Purchase> CreateAsync(CreatePurchaseDto dto, Guid userId)
        {
            var ticker = dto.Ticker.Trim().ToUpperInvariant();
            var asset = await _assetService.GetByTickerAsync(ticker);
            if (asset == null)
            {
                if (dto.Type == null)
                {
                    throw new ArgumentException($"Asset type must be provided for new assets.");
                }

                var quote = await _brapiService.GetQuoteAsync(ticker);
                if (quote == null)
                {
                    throw new ArgumentException($"Asset with ticker {ticker} not found.");
                }

                asset = new Asset
                {
                    Ticker = ticker,
                    Name = quote.LongName,
                    Type = dto.Type.Value,
                    Sector = dto.Sector?.Trim() ?? string.Empty,
                };
                asset = await _assetService.AddAsync(asset);
            }

            // Get or create the user's position in this asset
            var position = await _positionService.GetByUserAndAssetAsync(userId, asset.Id);
            if (position == null)
            {
                position = new Position
                {
                    UserId = userId,
                    AssetId = asset.Id,
                };
                position = await _positionService.AddAsync(position);
            }

            var purchase = new Purchase
            {
                PositionId = position.Id,
                Date = dto.Date,
                UnitPrice = dto.UnitPrice,
                Quantity = dto.Quantity,
                Taxes = dto.Taxes
            };

            purchase = await _repository.AddAsync(purchase);
            return purchase;
        }
    }
}
