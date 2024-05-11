using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.EntityConfig
{
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.ToTable("City");
            builder.HasKey(c => c.CityId);
            //builder.Property(c => c.CityId)
            //       .ValueGeneratedOnAdd();
            builder.Property(p => p.ProvinceId)
                   .IsRequired();
            builder.Property(n => n.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasOne<Province>(c => c.ProvinceObject)
                   .WithMany(c => c.CityObjects)
                   .HasForeignKey(c => c.ProvinceId);
        }
    }
}
