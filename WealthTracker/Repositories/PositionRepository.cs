using Microsoft.EntityFrameworkCore;
using WealthTracker.Data;
using WealthTracker.Entities;

namespace WealthTracker.Repositories
{
    public class PositionRepository : IPositionRepository
    {
        private readonly AppDbContext _context;
        public PositionRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Position>> GetAllAsync()
        {
            var positions = await _context.Positions.ToListAsync();
            return positions;
        }

        public async Task<Position?> GetByUserAndAssetAsync(Guid userId, int assetId)
        {
            var position = await _context.Positions.FirstOrDefaultAsync(p => p.UserId == userId && p.AssetId == assetId );
            return position;
        }

        public async Task<Position> AddAsync(Position position)
        {
            await _context.Positions.AddAsync(position);
            await _context.SaveChangesAsync();
            return position;
        }
    }
}
