using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class ApplicationStatusTypeConfig : IEntityTypeConfiguration<ApplicationStatusTypes>
    {
        public void Configure(EntityTypeBuilder<ApplicationStatusTypes> builder)
        {
            builder.ToTable("ApplicationStatusType");
            builder.HasKey(i => i.ApplicationStatusTypeId);
            builder.Property(i => i.ApplicationStatusTypeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasMany<Applications>(j => j.Applications)
                   .WithOne(c => c.ApplicationStatusType)
                   .HasForeignKey(c => c.ApplicationStatusTypeId);
        }
    }
}
