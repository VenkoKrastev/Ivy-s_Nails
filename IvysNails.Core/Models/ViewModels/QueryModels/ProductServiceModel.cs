using IvysNails.Core.Contracts;
using IvysNails.Core.Services;
using System.ComponentModel.DataAnnotations;
using static IvysNails.Infrastructure.Data.DataConstants;

namespace IvysNails.Core.Models.ViewModels.QueryModels
{
    public class ProductServiceModel : IProductModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(ProductNameMaxLength, MinimumLength = ProductNameMinLength, ErrorMessage = LengthErrorMessage)]
        public string Title { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), ProductPriceMinValue, ProductPriceMaxValue, ErrorMessage = RangeErrorMessage)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(ProductImageUrlMaxLength, MinimumLength = ProductImageUrlMinLength, ErrorMessage = LengthErrorMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [StringLength(ProductDetailsMaxLength, MinimumLength = ProductDetailsMinLength, ErrorMessage = LengthErrorMessage)]
       public string Details { get; set; }


    }
}
