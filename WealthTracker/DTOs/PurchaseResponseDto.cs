namespace WealthTracker.DTOs
{
    public class PurchaseResponseDto
    {
        public int Id { get; set; }
        public string Ticker { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Taxes { get; set; }
    }
}
