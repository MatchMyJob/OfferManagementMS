using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferCategoryConfig : IEntityTypeConfiguration<OfferCategories>
    {
        public void Configure(EntityTypeBuilder<OfferCategories> builder)
        {
            builder.ToTable("OfferCategory");
            builder.HasKey(i => i.OfferCategoryId);
            builder.Property(i => i.OfferCategoryId).ValueGeneratedOnAdd();
            builder.Property(o => o.OfferId).IsRequired();
            builder.Property(c => c.CategoryId).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.HasOne<Offers>(j => j.Offer)
               .WithMany(c => c.OfferCategories)
               .HasForeignKey(c => c.OfferId);
            builder.HasOne<Categories>(j => j.Category)
               .WithMany(c => c.OfferCategories)
               .HasForeignKey(c => c.CategoryId);
        }
    }
}
