using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferSkillConfig : IEntityTypeConfiguration<OfferSkill>
    {
        public void Configure(EntityTypeBuilder<OfferSkill> builder)
        {
            builder.ToTable("OfferSkill");
            builder.HasKey(i => i.OfferSkillId);
            builder.Property(i => i.OfferSkillId).ValueGeneratedOnAdd();
            builder.Property(s => s.SkillId).IsRequired();
            builder.Property(o => o.OfferId).IsRequired();
            builder.HasOne<Offer>(j => j.Offer)
                   .WithMany(c => c.OfferSkills)
                   .HasForeignKey(c => c.OfferId);
        }
    }
}
