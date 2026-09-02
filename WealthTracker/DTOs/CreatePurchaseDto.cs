using WealthTracker.Enums;

namespace WealthTracker.DTOs
{
    public class CreatePurchaseDto
    {
        public string Ticker { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Taxes { get; set; }
        public AssetType Type { get; set; }
    }
}
