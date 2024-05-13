using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");
            builder.HasKey(i => i.SkillId);
            builder.Property(i => i.SkillId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
            builder.HasData(
            new Skill
            {
                SkillId = 1,
                Name = "Proactividad"
            },
            new Skill
            {
                SkillId = 2,
                Name = "Comunicación efectiva"
            },
            new Skill
            {
                SkillId = 3,
                Name = "Trabajo en equipo"
            },
            new Skill
            {
                SkillId = 4,
                Name = "Pensamiento crítico"
            },
            new Skill
            {
                SkillId = 5,
                Name = "Resolución de problemas"
            },
            new Skill
            {
                SkillId = 6,
                Name = "Creatividad"
            },
            new Skill
            {
                SkillId = 7,
                Name = "Adaptabilidad"
            },
            new Skill
            {
                SkillId = 8,
                Name = "Gestión del tiempo"
            },
            new Skill
            {
                SkillId = 9,
                Name = "Liderazgo"
            },
            new Skill
            {
                SkillId = 10,
                Name = "Habilidades tecnológicas"
            },
            new Skill
            {
                SkillId = 11,
                Name = "Empatía"
            },
            new Skill
            {
                SkillId = 12,
                Name = "Toma de decisiones"
            },
            new Skill
            {
                SkillId = 13,
                Name = "Tolerancia a la frustración"
            },
            new Skill
            {
                SkillId = 14,
                Name = "Pensamiento estratégico"
            });
        }
    }
}
