using WealthTracker.Data;
using WealthTracker.Entities;
using Microsoft.EntityFrameworkCore;

namespace WealthTracker.Repositories
{
    public class PurchaseRepository : IPurchaseRepository
    {
        private readonly AppDbContext _context;
        
        public PurchaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Purchase>> GetAllAsync()
        {
            var purchases = await _context.Purchases.ToListAsync();
            return purchases;
        }

        public async Task<Purchase> AddAsync(Purchase purchase)
        {
            await _context.Purchases.AddAsync(purchase);
            await _context.SaveChangesAsync();
            return purchase;
        }
    }
}
