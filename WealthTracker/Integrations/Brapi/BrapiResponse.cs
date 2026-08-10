namespace WealthTracker.Integrations.Brapi
{
    public class BrapiQuote
    {
        public string Symbol { get; set; } = string.Empty;
        public string LongName { get; set; } = string.Empty;
        public decimal RegularMarketPrice { get; set; }
    }

    public class BrapiResponse
    {
        public List<BrapiQuote> Results { get; set; } = new List<BrapiQuote>();
    }
}
