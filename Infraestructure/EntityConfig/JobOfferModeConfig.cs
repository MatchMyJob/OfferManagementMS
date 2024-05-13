using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class JobOfferModeConfig : IEntityTypeConfiguration<JobOfferMode>
    {
        public void Configure(EntityTypeBuilder<JobOfferMode> builder)
        {
            builder.ToTable("JobOfferMode");
            builder.HasKey(i => i.JobOfferModeId);
            builder.Property(i => i.JobOfferModeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(new JobOfferMode
            {
                JobOfferModeId = 1,
                Name = "Presencial"
            },
            new JobOfferMode
            {
                JobOfferModeId = 2,
                Name = "Remoto"
            },
            new JobOfferMode
            {
                JobOfferModeId = 3,
                Name = "Hibrido"
            });
        }
    }
}
