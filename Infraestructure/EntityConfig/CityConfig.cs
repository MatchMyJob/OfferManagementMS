using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CityConfig : IEntityTypeConfiguration<Cities>
    {
        public void Configure(EntityTypeBuilder<Cities> builder)
        {
            builder.ToTable("City");
            builder.HasKey(i => i.CityId);
            builder.Property(i => i.CityId).ValueGeneratedOnAdd();
            builder.Property(p => p.ProvinceId).IsRequired();
            builder.Property(n => n.Name).IsRequired();
            builder.HasOne<Provinces>(j => j.Province)
                  .WithMany(c => c.Cities)
                  .HasForeignKey(c => c.ProvinceId);
        }
    }
}
