using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Diagnostics.Metrics;

namespace Infraestructure.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(i => i.CountryId);
            builder.Property(i => i.CountryId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(
                new Country { CountryId = 1, Name = "Argentina" }
                );
        }
    }
}
