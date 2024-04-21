using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class JobOfferModeConfig : IEntityTypeConfiguration<JobOfferModes>
    {
        public void Configure(EntityTypeBuilder<JobOfferModes> builder)
        {
            builder.ToTable("JobOfferMode");
            builder.HasKey(i => i.JobOfferModeId);
            builder.Property(i => i.JobOfferModeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(new JobOfferModes
            {
                JobOfferModeId = 1,
                Name = "Presencial"
            },
            new JobOfferModes
            {
                JobOfferModeId = 2,
                Name = "Remoto"
            },
            new JobOfferModes
            {
                JobOfferModeId = 3,
                Name = "Hibrido"
            });
        }
    }
}
