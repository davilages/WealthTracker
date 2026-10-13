using Microsoft.EntityFrameworkCore;

namespace WealthTracker.Entities
{
    [Index(nameof(UserId), nameof(AssetId), IsUnique = true)]
    public class Position
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int AssetId { get; set; }
        public Asset? Asset { get; set; }
        public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
        public ICollection<Sale> Sales { get; set; } = new List<Sale>();
        public ICollection<Dividend> Dividends { get; set; } = new List<Dividend>();
    }
}
