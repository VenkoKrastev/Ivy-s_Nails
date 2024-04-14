using IvysNails.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IvysNails.Infrastructure.Data.SeedData
{
    internal class ServicesConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            var data = new SeedData();

            builder.HasData(new Service[] {data.Varnishing, data.BuildingNails, data.VarnishingWithGelNailPolish, data.ManicureForMen, data.Pedicure, data.MedicalPedicure});
        }
    }
}
