using WealthTracker.Entities;

namespace WealthTracker.Repositories
{
    public interface IAssetRepository
    {
        public Task<IEnumerable<Asset>> GetAllAsync();
        public Task<Asset?> GetByIdAsync(int id);
        public Task<Asset> AddAsync(Asset asset);
        public Task<Asset?> GetByTickerAsync(string ticker);
    }
}
