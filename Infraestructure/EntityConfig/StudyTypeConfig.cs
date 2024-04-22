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
            builder.HasData(
            new StudyTypes
            {
                StudyTypeId = 1,
                Name = "Secundario"
            },
            new StudyTypes
            {
                StudyTypeId = 2,
                Name = "Terciario"
            },
            new StudyTypes
            {
                StudyTypeId = 3,
                Name = "Universitario"
            },
            new StudyTypes
            {
                StudyTypeId = 4,
                Name = "Postgrado"
            },
            new StudyTypes
            {
                StudyTypeId = 5,
                Name = "Maestría"
            });
        }
    }
}
