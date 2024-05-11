using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.EntityConfig
{
    public class ProvinceConfig : IEntityTypeConfiguration<Province>

    {
        public void Configure(EntityTypeBuilder<Province> builder)
        {
            builder.ToTable("Province");
            builder.HasKey(p => p.ProvinceId);
            builder.Property(c => c.CountryId)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne<Country>(c => c.CountryObject)
                   .WithMany(ps => ps.ProvinceObjects)
                   .HasForeignKey(fk => fk.CountryId);

            builder.HasMany<City>(cs => cs.CityObjects)
                   .WithOne(p => p.ProvinceObject)
                   .HasForeignKey(fk => fk.ProvinceId);
        }
    }
}
