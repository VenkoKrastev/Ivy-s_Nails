using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IvysNails.Data.DataConstants;


namespace IvysNails.Infrastructure.Data.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CustomerNameMaxLength)]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [MaxLength(CustomerPhoneNumberMaxLength)]
        public string CustomerPhoneNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(CustomerEmailMaxLength)]
        public string Email { get; set; } = string.Empty;
    }
}
