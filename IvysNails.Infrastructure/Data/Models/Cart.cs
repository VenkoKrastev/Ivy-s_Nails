using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace IvysNails.Infrastructure.Data.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("The current user's Identifier")]
        public string UserId { get; set; } = null!;

        //[ForeignKey(nameof(UserId))]
        //[Comment("The current User")]
        //public ApplicationUser User { get; set; } = null!;

        public ICollection<ProductCart> ProductsCarts { get; set; } = new HashSet<ProductCart>();

    }
}
