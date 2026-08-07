namespace WealthTracker.Entities
{
    public class Dividend
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; } = 0;
    }
}
