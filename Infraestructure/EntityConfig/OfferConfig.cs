using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class OfferConfig : IEntityTypeConfiguration<Offers>
    {
        public void Configure(EntityTypeBuilder<Offers> builder)
        {
            builder.ToTable("Offer");
            builder.HasKey(i => i.OfferId);
            builder.Property(i => i.OfferId).ValueGeneratedOnAdd();
            builder.Property(c => c.CompanyId).IsRequired();
            builder.Property(t => t.Title).IsRequired();
            builder.Property(d => d.Description).IsRequired();
            builder.Property(d => d.JobOfferModeId).IsRequired();
            builder.Property(d => d.PublicationDate).IsRequired();
            builder.Property(d => d.CityId).IsRequired();
            builder.Property(d => d.AvailabilityToTravel).IsRequired();
            builder.Property(d => d.AvailabilityChangeOfResidence).IsRequired();
            builder.Property(d => d.StudyTypeId).IsRequired();
            builder.Property(d => d.Status).IsRequired();
            builder.HasOne<StudyTypes>(j => j.StudyType)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.StudyTypeId);
            builder.HasOne<JobOfferModes>(j => j.JobOfferMode)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.JobOfferModeId);
            builder.HasOne<Cities>(j => j.City)
                   .WithMany(o => o.Offers)
                   .HasForeignKey(o => o.CityId);
            builder.HasMany<Applications>(j => j.Applications)
                   .WithOne(c => c.Offer)
                   .HasForeignKey(c => c.OfferId);

        }
    }
}
