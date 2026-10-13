using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using WealthTracker.Enums;

namespace WealthTracker.Entities
{
    [Index(nameof(Ticker), IsUnique = true)]
    public class Asset
    {
        public int Id { get; set; }
        [MaxLength(10)]
        public string Ticker { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        [MaxLength(100)]
        public string Sector { get; set; } = string.Empty;
        public AssetType Type { get; set; }
    }
}
