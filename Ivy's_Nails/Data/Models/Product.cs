using IvysNails.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static IvysNails.Data.DataConstants;

namespace IvysNails.Data.Models
{
    public class Product
    {
        [Key]
        [Comment("The current Product's Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        [Comment("The name of product")]
        public string Name { get; set; } = null!;

        [Required]
        [Precision(18, 2)]
        [Comment("The current Products Price")]
        public decimal Price { get; set; }

        [Required]
        [Comment("Available quantity of the product")]
        public int StockQuantity { get; set; }

        [Required]
        [MaxLength(ProductDetailsMaxLength)]
        [Comment("Product details")]
        public string Details { get; set; } = null!;

        [Required]
        [StringLength(ProductImageUrlMaxLength)]
        [Comment("The current picture of product")]
        public string ImageUrl { get; set; } = null!;

        public ICollection<ProductCart> ProductsCarts { get; set; } = new HashSet<ProductCart>();


    }
}
