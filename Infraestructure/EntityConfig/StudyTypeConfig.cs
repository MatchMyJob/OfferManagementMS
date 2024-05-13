using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class StudyTypeConfig : IEntityTypeConfiguration<StudyType>
    {
        public void Configure(EntityTypeBuilder<StudyType> builder)
        {
            builder.ToTable("StudyType");
            builder.HasKey(i => i.StudyTypeId);
            builder.Property(i => i.StudyTypeId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(
            new StudyType
            {
                StudyTypeId = 1,
                Name = "Secundario"
            },
            new StudyType
            {
                StudyTypeId = 2,
                Name = "Terciario"
            },
            new StudyType
            {
                StudyTypeId = 3,
                Name = "Universitario"
            },
            new StudyType
            {
                StudyTypeId = 4,
                Name = "Postgrado"
            },
            new StudyType
            {
                StudyTypeId = 5,
                Name = "Maestría"
            });
        }
    }
}
