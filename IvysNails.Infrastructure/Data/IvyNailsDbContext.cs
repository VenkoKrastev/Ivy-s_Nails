namespace IvysNails.Infrastructure.Data
{
    using IvysNails.Infrastructure.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class IvyNailsDbContext : IdentityDbContext
    {
        public IvyNailsDbContext(DbContextOptions<IvyNailsDbContext> options)
            : base(options) { }

        public DbSet<Cart> Carts { get; set; } = null!;
       
        public DbSet<Service> Services { get; set; } = null!;

        public DbSet<Customer> Customers { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }
    
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
