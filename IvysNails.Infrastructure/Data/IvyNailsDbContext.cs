namespace IvysNails.Infrastructure.Data
{
    using IvysNails.Infrastructure.Data.Models;
    using IvysNails.Infrastructure.Data.Models.Roles;
    using IvysNails.Infrastructure.Data.SeedData;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class IvyNailsDbContext : IdentityDbContext<ApplicationUser>
    {
        public IvyNailsDbContext(DbContextOptions<IvyNailsDbContext> options)
            : base(options) { }

        public DbSet<Cart> Carts { get; set; } = null!;
       
        public DbSet<Service> Services { get; set; } = null!;

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Appointment> Appointments { get; set; }

        public DbSet<ProductCart> ProductCarts { get; set; }

        public DbSet<Product> Products { get; set; }
    
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Appointment>()
                .HasKey(a => new { a.ServiceId, a.CustomerId });

            builder.Entity<ProductCart>()
                .HasKey(pc => new { pc.ProductId, pc.CartId });

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

            //Configuration (Data Seeding)
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new ProductCategoryConfiguration());
            builder.ApplyConfiguration(new AdminConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new ServicesConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
