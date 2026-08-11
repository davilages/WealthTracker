using Microsoft.EntityFrameworkCore;
using WealthTracker.Data;
using WealthTracker.Entities;

namespace WealthTracker.Repositories
{
    public class AssetRepository : IAssetRepository
    {
        // Inject DbContext
        private readonly AppDbContext _context;
        public AssetRepository(AppDbContext context)
        {
            _context = context;
        }

        // Get all assets
        public async Task<IEnumerable<Asset>> GetAllAsync()
        {
            var assets = await _context.Assets.ToListAsync();
            return assets;
        }

        // Get asset by ID
        public async Task<Asset?> GetByIdAsync(int id)
        {
            var asset = await _context.Assets.FindAsync(id);
            return asset;
        }

        // Get asset by ticker
        public async Task<Asset?> GetByTickerAsync(string ticker)
        {
            var asset = await _context.Assets.FirstOrDefaultAsync(a => a.Ticker == ticker);
            return asset;
        }

        // Create a new asset
        public async Task<Asset> AddAsync(Asset asset)
        {
            await _context.Assets.AddAsync(asset);
            await _context.SaveChangesAsync();
            return asset;
        }
    }
}
