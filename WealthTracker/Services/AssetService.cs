using WealthTracker.Entities;
using WealthTracker.Repositories;

namespace WealthTracker.Services
{
    public class AssetService : IAssetService
    {
        // Injection
        private readonly IAssetRepository _repository;

        public AssetService(IAssetRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<Asset>> GetAllAsync()
        {
            var assets = await _repository.GetAllAsync();
            return assets;
        }
        public async Task<Asset?> GetByIdAsync(int id)
        {
            var asset = await _repository.GetByIdAsync(id);
            return asset;
        }
        public async Task<Asset> AddAsync(Asset asset)
        {
            return await _repository.AddAsync(asset);
        }
    }
}
