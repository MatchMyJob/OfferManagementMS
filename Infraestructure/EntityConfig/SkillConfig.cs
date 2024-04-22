using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class SkillConfig : IEntityTypeConfiguration<Skills>
    {
        public void Configure(EntityTypeBuilder<Skills> builder)
        {
            builder.ToTable("Skill");
            builder.HasKey(i => i.SkillId);
            builder.Property(i => i.SkillId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(
            new Skills
            {
                SkillId = 1,
                Name = "Proactividad"
            },
            new Skills
            {
                SkillId = 2,
                Name = "Comunicación efectiva"
            },
            new Skills
            {
                SkillId = 3,
                Name = "Trabajo en equipo"
            },
            new Skills
            {
                SkillId = 4,
                Name = "Pensamiento crítico"
            },
            new Skills
            {
                SkillId = 5,
                Name = "Resolución de problemas"
            },
            new Skills
            {
                SkillId = 6,
                Name = "Creatividad"
            },
            new Skills
            {
                SkillId = 7,
                Name = "Adaptabilidad"
            },
            new Skills
            {
                SkillId = 8,
                Name = "Gestión del tiempo"
            },
            new Skills
            {
                SkillId = 9,
                Name = "Liderazgo"
            },
            new Skills
            {
                SkillId = 10,
                Name = "Habilidades tecnológicas"
            },
            new Skills
            {
                SkillId = 11,
                Name = "Empatía"
            },
            new Skills
            {
                SkillId = 12,
                Name = "Toma de decisiones"
            },
            new Skills
            {
                SkillId = 13,
                Name = "Tolerancia a la frustración"
            },
            new Skills
            {
                SkillId = 14,
                Name = "Pensamiento estratégico"
            });
        }
    }
}
