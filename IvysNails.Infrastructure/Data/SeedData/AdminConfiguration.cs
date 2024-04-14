using IvysNails.Infrastructure.Data.Models.Roles;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IvysNails.Infrastructure.Data.SeedData
{
    internal class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            var data = new SeedData();

            builder.HasData(new Admin[] { data.Admin });
        }
    }
}
