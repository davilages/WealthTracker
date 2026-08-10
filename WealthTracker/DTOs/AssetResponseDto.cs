using WealthTracker.Enums;

namespace WealthTracker.DTOs
{
    public class AssetResponseDto
    {
        public int Id { get; set; }
        public string Ticker { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Sector { get; set; } = string.Empty;
        public AssetType Type { get; set; }
    }
}
