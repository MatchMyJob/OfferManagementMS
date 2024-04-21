using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferSkillConfig : IEntityTypeConfiguration<OfferSkills>
    {
        public void Configure(EntityTypeBuilder<OfferSkills> builder)
        {
            builder.ToTable("OfferSkill");
            builder.HasKey(i => i.OfferSkillId);
            builder.Property(i => i.OfferSkillId).ValueGeneratedOnAdd();
            builder.Property(s => s.SkillId).IsRequired();
            builder.Property(o => o.OfferId).IsRequired();
            builder.HasOne<Offers>(j => j.Offer)
                   .WithMany(c => c.OfferSkills)
                   .HasForeignKey(c => c.OfferId);
        }
    }
}
