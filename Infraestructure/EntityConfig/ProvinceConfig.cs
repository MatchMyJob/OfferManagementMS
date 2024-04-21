using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ProvinceConfig : IEntityTypeConfiguration<Provinces>
    {
        public void Configure(EntityTypeBuilder<Provinces> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(i => i.ProvinceId);
            builder.Property(i => i.ProvinceId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.Property(c => c.CountryId).IsRequired();
            builder.HasOne<Countries>(j => j.Country)
                   .WithMany(c => c.Provinces)
                   .HasForeignKey(c => c.CountryId);
        }
    }
}
