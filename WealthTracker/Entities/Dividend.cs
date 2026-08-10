using Microsoft.EntityFrameworkCore;

namespace WealthTracker.Entities
{
    public class Dividend
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public DateTime Date { get; set; }
        [Precision(18, 2)]
        public decimal Amount { get; set; } = 0;
    }
}
