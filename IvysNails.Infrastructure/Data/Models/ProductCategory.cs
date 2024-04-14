using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static IvysNails.Data.DataConstants;

namespace IvysNails.Infrastructure.Data.Models
{
    public class ProductCategory
    {
        [Key]
        [Comment("The current Category's Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductCategoryMaxLength)]
        [Comment("The Name of product category")]
        public string Name { get; set; } = null!;

        public List<Product> Products { get; set; } = new List<Product>();

    }
}
