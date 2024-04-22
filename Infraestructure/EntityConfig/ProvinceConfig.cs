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
            builder.HasData(
               new Provinces { CountryId = 1, ProvinceId = 06, Name = "Buenos Aires" },
               new Provinces { CountryId = 1, ProvinceId = 02, Name = "Ciudad Autónoma de Buenos Aires" },
               new Provinces { CountryId = 1, ProvinceId = 82, Name = "Santa Fe" },
               new Provinces { CountryId = 1, ProvinceId = 42, Name = "La Pampa" },
               new Provinces { CountryId = 1, ProvinceId = 14, Name = "Cordoba" },
               new Provinces { CountryId = 1, ProvinceId = 30, Name = "Entre Rios" },
               new Provinces { CountryId = 1, ProvinceId = 54, Name = "Misiones" },
               new Provinces { CountryId = 1, ProvinceId = 34, Name = "Formosa" },
               new Provinces { CountryId = 1, ProvinceId = 22, Name = "Chaco" },
               new Provinces { CountryId = 1, ProvinceId = 90, Name = "Tucuman" },
               new Provinces { CountryId = 1, ProvinceId = 10, Name = "Catamarca" },
               new Provinces { CountryId = 1, ProvinceId = 66, Name = "Salta" },
               new Provinces { CountryId = 1, ProvinceId = 38, Name = "Jujuy" },
               new Provinces { CountryId = 1, ProvinceId = 46, Name = "La Rioja" },
               new Provinces { CountryId = 1, ProvinceId = 70, Name = "San Juan" },
               new Provinces { CountryId = 1, ProvinceId = 74, Name = "San Luis" },
               new Provinces { CountryId = 1, ProvinceId = 50, Name = "Mendoza" },
               new Provinces { CountryId = 1, ProvinceId = 58, Name = "Neuquen" },
               new Provinces { CountryId = 1, ProvinceId = 18, Name = "Corrientes" },
               new Provinces { CountryId = 1, ProvinceId = 62, Name = "Rio Negro" },
               new Provinces { CountryId = 1, ProvinceId = 26, Name = "Chubut" },
               new Provinces { CountryId = 1, ProvinceId = 94, Name = "Tierra Del Fuego" }
               );
        }
    }
}
