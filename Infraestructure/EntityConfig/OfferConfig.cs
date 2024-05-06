using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferConfig : IEntityTypeConfiguration<Offers>
    {
        public void Configure(EntityTypeBuilder<Offers> builder)
        {
            builder.ToTable("Offer");
            builder.HasKey(i => i.OfferId);
            builder.Property(i => i.OfferId).ValueGeneratedOnAdd();
            builder.Property(c => c.CompanyId).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.Property(d => d.Description).IsRequired();
            builder.Property(d => d.JobOfferModeId).IsRequired();
            builder.Property(d => d.PublicationDate).IsRequired().HasDefaultValue(DateTime.Now);
            builder.Property(d => d.CityId).IsRequired();
            builder.Property(d => d.AvailabilityToTravel).IsRequired();
            builder.Property(d => d.AvailabilityChangeOfResidence).IsRequired();
            builder.Property(d => d.StudyTypeId).IsRequired();
            builder.Property(d => d.Status).IsRequired();
            builder.HasOne<StudyTypes>(j => j.StudyType)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.StudyTypeId);
            builder.HasOne<JobOfferModes>(j => j.JobOfferMode)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.JobOfferModeId);
            builder.HasOne<Cities>(j => j.City)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.CityId);   
            builder.HasMany<Applications>(j => j.Applications)
                   .WithOne(c => c.Offer)
                   .HasForeignKey(c => c.OfferId);
            builder.HasData(
                    new Offers
                    {
                        OfferId = Guid.NewGuid(),
                        CompanyId = 1,
                        Title = "Analistas y Analistas Sr. Financieros/Contables - Control de Gestión",
                        Description = "Los profesionales de Client Financial Management (CFM) dan soporte al control de gestión financiera de proyectos para clientes globales. Brinda servicios de control de gestión desde el inicio hasta la finalización del contrato realizando análisis de presupuestos y seguimiento de proyección financiera, conciliación de servicios vs facturación y cobros, incluyendo el monitoreo de variaciones y el seguimiento de discrepancias. Además de brindar asesoramiento para nuestros directivos corporativos y los equipos relacionados con los clientes.\r\n\r\nEntre las tareas diarias se encuentran:\r\n\r\nAnálisis de datos históricos para precisión en el armado de presupuesto\r\nAsistir/Asesorar en actividades de presupuesto.\r\nCreación y manejo de reportes y análisis de control de gestión para la identificación de “red flags” ante posibles desvíos.\r\nFacturación de servicios al cliente. Seguimiento de facturación y cobro.\r\nCumplimiento de procesos con cierres en fechas establecidas mensualmente.\r\nConciliación de servicios vs facturación y cobros, incluyendo el monitoreo de variaciones.\r\nAsistir al líder de proyecto en la creación de valor para la gestión financiera.\r\nJob Qualifications\r\n\r\nRequisitos excluyentes:\r\n\r\nEstudiante o graduado de carreras de Ciencias Económicas o afines\r\nPoseer + 1 año de experiencia laboral en tareas administrativas, contables, financieras o en posiciones similares\r\nDisponibilidad para trabajar full-time\r\nConocimiento de inglés avanzado\r\nConocimiento de excel intermedio/avanzado\r\nBuena comunicación (oral y escrita) y aptitudes interpersonales.\r\nAtención al detalle\r\n",
                        JobOfferModeId = 1,
                        PublicationDate = new DateTime(2024, 4, 21),
                        CityId = 060343,
                        AvailabilityToTravel = false,
                        AvailabilityChangeOfResidence = false,
                        StudyTypeId = 1,
                        Status = true
                    },
                    new Offers
                    {
                        OfferId = Guid.NewGuid(),
                        CompanyId = 1,
                        Title = "Analistas y Analistas Sr. Financieros/Contables - Control de Gestión",
                        Description = "Los profesionales de Client Financial Management (CFM) dan soporte al control de gestión financiera de proyectos para clientes globales. Brinda servicios de control de gestión desde el inicio hasta la finalización del contrato realizando análisis de presupuestos y seguimiento de proyección financiera, conciliación de servicios vs facturación y cobros, incluyendo el monitoreo de variaciones y el seguimiento de discrepancias. Además de brindar asesoramiento para nuestros directivos corporativos y los equipos relacionados con los clientes.\r\n\r\nEntre las tareas diarias se encuentran:\r\n\r\nAnálisis de datos históricos para precisión en el armado de presupuesto\r\nAsistir/Asesorar en actividades de presupuesto.\r\nCreación y manejo de reportes y análisis de control de gestión para la identificación de “red flags” ante posibles desvíos.\r\nFacturación de servicios al cliente. Seguimiento de facturación y cobro.\r\nCumplimiento de procesos con cierres en fechas establecidas mensualmente.\r\nConciliación de servicios vs facturación y cobros, incluyendo el monitoreo de variaciones.\r\nAsistir al líder de proyecto en la creación de valor para la gestión financiera.\r\nJob Qualifications\r\n\r\nRequisitos excluyentes:\r\n\r\nEstudiante o graduado de carreras de Ciencias Económicas o afines\r\nPoseer + 1 año de experiencia laboral en tareas administrativas, contables, financieras o en posiciones similares\r\nDisponibilidad para trabajar full-time\r\nConocimiento de inglés avanzado\r\nConocimiento de excel intermedio/avanzado\r\nBuena comunicación (oral y escrita) y aptitudes interpersonales.\r\nAtención al detalle\r\n",
                        JobOfferModeId = 1,
                        PublicationDate = DateTime.Now,
                        CityId = 060343,
                        AvailabilityToTravel = false,
                        AvailabilityChangeOfResidence = false,
                        StudyTypeId = 1,
                        Status = true
                    });

        }
    }
}
