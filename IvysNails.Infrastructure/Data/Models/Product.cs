﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static IvysNails.Infrastructure.Data.DataConstants;

namespace IvysNails.Infrastructure.Data.Models
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

        [Required]
        public int ProductCategoryId { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        public ProductCategory ProductsCategories { get; set; } = null!;




    }
}
