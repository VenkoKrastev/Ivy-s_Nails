using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static IvysNails.Data.DataConstants;


namespace IvysNails.Data.Models
{
    public class Appointment
    {
        [Key]
        [Comment("The current Product's Identifier")]
        public int Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Range(30, 60)]
        public int Duration { get; set; }

        [Required]
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        public Service Service { get; set; } = null!;
        
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        public Customer Customer { get; set; } = null!;
    }
}
