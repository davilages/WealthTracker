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
        public string? Sector { get; set; } // Used only when the asset is new
        public AssetType? Type { get; set; } // Optional property for asset type, can be null if not provided - only necessary when it's a new asset being created
    }
}
