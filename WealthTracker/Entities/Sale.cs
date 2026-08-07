namespace WealthTracker.Entities
{
    public class Sale
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public DateTime Date { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Taxes { get; set; } = 0;
    }
}
