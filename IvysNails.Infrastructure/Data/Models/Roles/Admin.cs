using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IvysNails.Infrastructure.Data.Models.Roles
{
    public class Admin
    {
        [Key]
        [Comment("The current Admin's Identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("The current User's Identifier")]
        public string UserId { get; set; } = null!;

        [ForeignKey(nameof(UserId))]
        [Comment("The current User")]
        public ApplicationUser User { get; set; } = null!;
    }
}
