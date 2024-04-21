using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class StudyTypeConfig : IEntityTypeConfiguration<StudyTypes>
    {
        public void Configure(EntityTypeBuilder<StudyTypes> builder)
        {
            builder.ToTable("StudyType");
            builder.HasKey(i => i.StudyTypeId);
            builder.Property(i => i.StudyTypeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
        }
    }
}
