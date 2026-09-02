using Microsoft.EntityFrameworkCore;
using WealthTracker.Entities;

namespace WealthTracker.Repositories
{
    public interface IPositionRepository
    {
        public Task<IEnumerable<Position>> GetAllAsync();
        public Task<Position?> GetByUserAndAssetAsync(Guid userId, int assetId);
        public Task<Position> AddAsync(Position position);
    }
}