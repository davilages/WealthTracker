using System.ComponentModel.DataAnnotations;
using WealthTracker.Enums;

namespace WealthTracker.DTOs
{
    public class CreatePurchaseDto : IValidatableObject
    {
        [Required]
        [MaxLength(10)]
        public string Ticker { get; set; } = string.Empty;

        [Required] // Nullable so a missing date fails validation instead of defaulting to 0001-01-01
        public DateTime? Date { get; set; }

        [Range(0.00000001, double.MaxValue)]
        public decimal Quantity { get; set; }

        [Range(0.01, double.MaxValue)]
        public decimal UnitPrice { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Taxes { get; set; }

        [MaxLength(100)]
        public string? Sector { get; set; } // Used only when the asset is new

        [EnumDataType(typeof(AssetType))]
        public AssetType? Type { get; set; } // Required only when the asset is new (checked in PurchaseService)

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Date?.Date > DateTime.Today)
            {
                yield return new ValidationResult("Purchase date cannot be in the future.", new[] { nameof(Date) });
            }
        }
    }
}
