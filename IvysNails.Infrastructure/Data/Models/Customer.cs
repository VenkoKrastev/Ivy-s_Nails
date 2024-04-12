using System.ComponentModel.DataAnnotations;
using static IvysNails.Data.DataConstants;


namespace IvysNails.Infrastructure.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CustomerNameMaxLength)]
        public string CustomerName { get; set; } = null!;

        [Required]
        [MaxLength(CustomerPhoneNumberMaxLength)]
        public string CustomerPhoneNumber { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;
    }
}
