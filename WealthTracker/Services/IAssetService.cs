using WealthTracker.Entities;

namespace WealthTracker.Services
{
    public interface IAssetService
    {
        public Task<IEnumerable<Asset>> GetAllAsync();
        public Task<Asset?> GetByIdAsync(int id);
        public Task<Asset> AddAsync(Asset asset);
    }
}
