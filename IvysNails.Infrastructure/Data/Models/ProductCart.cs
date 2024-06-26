﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IvysNails.Infrastructure.Data.Models
{
    public class ProductCart
    {
        [Required]
        [Comment("The current Product's Identifier")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        [Comment("The current Product")]
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("The current Cart's Identifier")]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        [Comment("The current Cart")]
        public Cart Cart { get; set; } = null!;
    }
}
