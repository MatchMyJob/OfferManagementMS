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
        }
    }
}
