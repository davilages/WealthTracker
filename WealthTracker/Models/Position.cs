namespace WealthTracker.Models
{
    public class Position
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public int AssetId { get; set; }
        public Asset? Asset { get; set; }
    }
}
