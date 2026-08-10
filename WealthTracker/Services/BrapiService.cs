using System.Text.Json;
using WealthTracker.Integrations.Brapi;

namespace WealthTracker.Services
{
    public class BrapiService : IBrapiService
    {
        private readonly HttpClient _httpClient;
        private readonly JsonSerializerOptions _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        public BrapiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }   
        public async Task<BrapiQuote?> GetQuoteAsync(string ticker)
        {
            // Implementation for fetching quote from Brapi
            var url = $"https://brapi.dev/api/quote/{ticker}";
            try
            {
                var response = await _httpClient.GetFromJsonAsync<BrapiResponse>(url, _options);
                return response?.Results.FirstOrDefault();
            }
            catch (HttpRequestException)
            {
                return null;
            }
        }   
    }
}
