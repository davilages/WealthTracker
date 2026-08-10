using Microsoft.EntityFrameworkCore;

namespace WealthTracker.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PositionId { get; set; }
        public Position? Position { get; set; }
        public DateTime Date { get; set; }
        [Precision(18, 2)]
        public decimal UnitPrice { get; set; }

        [Precision(18, 8)]
        public decimal Quantity { get; set; }

        [Precision(18, 2)]
        public decimal Taxes { get; set; } = 0;
    }
}
