using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(i => i.CategoryId);
            builder.Property(i => i.CategoryId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(
            new Categories
            {
                CategoryId = 1,
                Name = "Administración, Contabilidad y Finanzas"
            },
            new Categories
            {
                CategoryId = 2,
                Name = "Comercial, Ventas y Negocios"
            },
            new Categories
            {
                CategoryId = 3,
                Name = "Oficios y Otros"
            },
            new Categories
            {
                CategoryId = 4,
                Name = "Gastronomía y Turismo"
            },
            new Categories
            {
                CategoryId = 5,
                Name = "Abastecimiento y Logística"
            },
            new Categories
            {
                CategoryId = 6,
                Name = "Atención al Cliente, Call Center y Telemarketing"
            },
            new Categories
            {
                CategoryId = 7,
                Name = "Recursos Humanos y Capacitación"
            },
            new Categories
            {
                CategoryId = 8,
                Name = "Salud, Medicina y Farmacia"
            },
            new Categories
            {
                CategoryId = 9,
                Name = "Tecnología, Sistemas y Telecomunicaciones"
            },
            new Categories
            {
                CategoryId = 10,
                Name = "Marketing y Publicidad"
            },
            new Categories
            {
                CategoryId = 11,
                Name = "Producción y Manufactura"
            },
            new Categories
            {
                CategoryId = 12,
                Name = "Ingenierías"
            },
            new Categories
            {
                CategoryId = 13,
                Name = "Secretarias y Recepción"
            },
            new Categories
            {
                CategoryId = 14,
                Name = "Legales"
            },
            new Categories
            {
                CategoryId = 15,
                Name = "Aduana y Comercio Exterior"
            },
            new Categories
            {
                CategoryId = 16,
                Name = "Ingeniería Civil y Construcción"
            },
            new Categories
            {
                CategoryId = 17,
                Name = "Diseño"
            },
            new Categories
            {
                CategoryId = 18,
                Name = "Seguros"
            },
            new Categories
            {
                CategoryId = 19,
                Name = "Gerencia y Dirección General"
            },
            new Categories
            {
                CategoryId = 20,
                Name = "Comunicación, Relaciones Institucionales y Públicas"
            },
            new Categories
            {
                CategoryId = 21,
                Name = "Educación, Docencia e Investigación"
            },
            new Categories
            {
                CategoryId = 22,
                Name = "Departamento Tecnico"
            },
            new Categories
            {
                CategoryId = 23,
                Name = "Enfermería"
            },
            new Categories
            {
                CategoryId = 24,
                Name = "Minería, Petróleo y Gas"
            },
            new Categories
            {
                CategoryId = 25,
                Name = "Naviero, Maritimo, Portuario"
            });
        }
    }
}
