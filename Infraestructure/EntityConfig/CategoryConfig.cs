using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(i => i.CategoryId);
            builder.Property(i => i.CategoryId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(new Category
            {
                CategoryId = 1,
                Name = "Administración, Contabilidad y Finanzas"

            },
            new Category
            {
                CategoryId = 2,
                Name = "Comercial, Ventas y Negocios"

            },
            new Category
            {
                CategoryId = 3,
                Name = "Oficios y Otros"
            },
            new Category
            {
                CategoryId = 4,
                Name = "Gastronomía y Turismo"
            },
            new Category
            {
                CategoryId = 5,
                Name = "Abastecimiento y Logística"
            },
            new Category
            {
                CategoryId = 6,
                Name = "Atención al Cliente, Call Center y Telemarketing"
            },
            new Category
            {
                CategoryId = 7,
                Name = "Recursos Humanos y Capacitación"
            },
            new Category
            {
                CategoryId = 8,
                Name = "Salud, Medicina y Farmacia"
            },
            new Category
            {
                CategoryId = 9,
                Name = "Tecnología, Sistemas y Telecomunicaciones"
            },
            new Category
            {
                CategoryId = 10,
                Name = "Marketing y Publicidad"
            },
            new Category
            {
                CategoryId = 11,
                Name = "Producción y Manufactura"
            },
            new Category
            {
                CategoryId = 12,
                Name = "Ingenierías"
            },
            new Category
            {
                CategoryId = 13,
                Name = "Secretarias y Recepción"
            },
            new Category
            {
                CategoryId = 14,
                Name = "Legales"
            },
            new Category
            {
                CategoryId = 15,
                Name = "Aduana y Comercio Exterior"
            },
            new Category
            {
                CategoryId = 16,
                Name = "Ingeniería Civil y Construcción"
            },
            new Category
            {
                CategoryId = 17,
                Name = "Diseño"
            },
            new Category
            {
                CategoryId = 18,
                Name = "Seguros"
            },
            new Category
            {
                CategoryId = 19,
                Name = "Gerencia y Dirección General"
            },
            new Category
            {
                CategoryId = 20,
                Name = "Comunicación, Relaciones Institucionales y Públicas"
            },
            new Category
            {
                CategoryId = 21,
                Name = "Educación, Docencia e Investigación"
            },
            new Category
            {
                CategoryId = 22,
                Name = "Departamento Tecnico"
            },
            new Category
            {
                CategoryId = 23,
                Name = "Enfermería"
            },
            new Category
            {
                CategoryId = 24,
                Name = "Minería, Petróleo y Gas"
            },
            new Category
            {
                CategoryId = 25,
                Name = "Naviero, Maritimo, Portuario"
            });
        }
    }
}
