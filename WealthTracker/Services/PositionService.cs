using WealthTracker.Entities;
using WealthTracker.Repositories;

namespace WealthTracker.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _repository;
        public PositionService(IPositionRepository repository)
        {
            _repository = repository;
        }
        public async Task<Position> AddAsync(Position position)
        {
            return await _repository.AddAsync(position);
        }
        public async Task<Position?> GetByUserAndAssetAsync(Guid userId, int assetId)
        {
            return await _repository.GetByUserAndAssetAsync(userId, assetId);
        }
    }
}
