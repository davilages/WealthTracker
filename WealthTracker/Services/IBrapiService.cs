using WealthTracker.Integrations.Brapi;

namespace WealthTracker.Services
{
    public interface IBrapiService
    {
        public Task<BrapiQuote?> GetQuoteAsync(string ticker);
    }
}
    