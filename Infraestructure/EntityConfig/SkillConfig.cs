using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure.Data;

namespace Infraestructure.EntityConfig
{
    public class SkillConfig : IEntityTypeConfiguration<Skill>

    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");
            builder.HasKey(s => s.SkillId);
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            SkillData.SeedData(builder);
        }
    }
}
