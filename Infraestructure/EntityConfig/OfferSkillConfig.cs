using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.EntityConfig
{
    public class OfferSkillConfig : IEntityTypeConfiguration<OfferSkill>

    {
        public void Configure(EntityTypeBuilder<OfferSkill> builder)
        {
            builder.ToTable("StudyType");
            builder.HasKey(s => s.OfferSkillId);

            builder.HasOne<Skill>(s => s.skill)
                   .WithMany()
                   .HasForeignKey(fk => fk.SkillId);

            builder.HasOne<Offer>(s => s.offer)
                   .WithMany()
                   .HasForeignKey(fk => fk.OfferId);
        }
    }
}
