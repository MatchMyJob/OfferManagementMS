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
        }
    }
}
