using WealthTracker.DTOs;
using WealthTracker.Entities;

namespace WealthTracker.Services
{
    public interface IPurchaseService
    {
        Task<Purchase> CreateAsync(CreatePurchaseDto dto, Guid userId);
    }
}