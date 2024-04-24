using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IvysNails.Infrastructure.Data.DataConstants;


namespace IvysNails.Core.Models.ViewModels.QueryModels
{
    public class ProductFormModel
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
        public string Details { get; set; } = string.Empty;

        [Required]
        [StringLength(1000)]
        public int Qty { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        public IEnumerable<ProductCategoryServiceModel> Categories { get; set; } = new List<ProductCategoryServiceModel>();


    }
}
