using WealthTracker.Entities;

namespace WealthTracker.Services
{
    public interface IPositionService
    {
        public Task<Position> AddAsync(Position position);
        public Task<Position?> GetByUserAndAssetAsync(Guid userId, int assetId);
    }
}
