using WealthTracker.Entities;

namespace WealthTracker.Repositories
{
    public interface IPurchaseRepository
    {
        Task<Purchase> AddAsync(Purchase purchase);
        Task<IEnumerable<Purchase>> GetAllAsync();
    }
}
