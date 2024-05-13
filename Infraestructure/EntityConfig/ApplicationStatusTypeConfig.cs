using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ApplicationStatusTypeConfig : IEntityTypeConfiguration<ApplicationStatusType>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatusType> builder)
        {
            builder.ToTable("ApplicationStatusType");
            builder.HasKey(i => i.ApplicationStatusTypeId);
            builder.Property(i => i.ApplicationStatusTypeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasMany<Domain.Entities.Aplication>(j => j.Applications)
                   .WithOne(c => c.ApplicationStatusType)
                   .HasForeignKey(c => c.ApplicationStatusTypeId);
            builder.HasData(
            new ApplicationStatusType
            {
                ApplicationStatusTypeId = 1,
                Name = "CV Enviado"
            },
            new ApplicationStatusType
            {
                ApplicationStatusTypeId = 2,
                Name = "CV Leido"
            },
            new ApplicationStatusType
            {
                ApplicationStatusTypeId = 3,
                Name = "Contactado"
            },
            new ApplicationStatusType
            {
                ApplicationStatusTypeId = 4,
                Name = "Avisos Activos"
            },
            new ApplicationStatusType
            {
                ApplicationStatusTypeId = 5,
                Name = "Avisos Finalizados"
            });
        }
    }
}
