using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Countries>
    {
        public void Configure(EntityTypeBuilder<Countries> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(i => i.CountryId);
            builder.Property(i => i.CountryId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();

        }
    }
}
