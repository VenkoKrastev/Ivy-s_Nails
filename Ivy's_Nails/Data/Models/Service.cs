using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static IvysNails.Data.DataConstants;


namespace IvysNails.Data.Models
{
    public class Service
    {
        [Key]
        [Comment("The current Service Identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ServiceNameMaxLength)]
        [Comment("The name of the service offered")]
        public string Name { get; set; } = null!;

        [Required]
        [Precision(18, 2)]
        [Comment("The price of current service")]
        public decimal Price { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customers { get; set; } = null!;

    }
}