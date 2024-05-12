using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Data;

namespace Infraestructure.EntityConfig
{
    public class CountryConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("Country");
            builder.HasKey(c => c.CountryId);
            builder.Property(c => c.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany<Province>(p => p.ProvinceObjects)
                   .WithOne(c => c.CountryObject)
                   .HasForeignKey(fk => fk.CountryId);
            CountryData.SeedData(builder);
        }
    }
}
