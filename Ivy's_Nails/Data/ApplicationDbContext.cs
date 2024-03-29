using Ivy_s_Nails.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Ivy_s_Nails.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCart> ProductsCarts { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Service> Services { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Appointment>()
                .HasKey(a => new { a.ServiceId, a.CustomerId });

            builder.Entity<ProductCart>()
                .HasKey(bc => new { bc.ProductId, bc.CartId });

            builder.Entity<Product>()
                .Property(b => b.Price)
                .HasPrecision(18, 2);

            //Configuration (Data Seeding)
            

            base.OnModelCreating(builder);
        }


    }
}
