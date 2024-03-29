using Ivy_s_Nails.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ivy_s_Nails.Data.Models
{
    public class Cart
    {
        [Key]
        [Comment("The current User's Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("The current user's Identifier")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        [Comment("The current User")]
        public IdentityUser User { get; set; } = null!;

        public ICollection<ProductCart> ProductsCarts { get; set; } = new HashSet<ProductCart>();

    }
}
