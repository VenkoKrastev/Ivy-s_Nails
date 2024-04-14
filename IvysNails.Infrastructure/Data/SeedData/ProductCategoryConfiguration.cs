using IvysNails.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IvysNails.Infrastructure.Data.SeedData
{
    internal class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            var data = new SeedData();

            builder.HasData(new ProductCategory[] {data.Shampoo, data.Hairspray, data.NailPolish, data.HairDye, data.NailFile});
        }
    }
}
