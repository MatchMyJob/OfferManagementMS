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
    public class OfferConfig : IEntityTypeConfiguration<Offer>

    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.ToTable("Offer");
            builder.HasKey(s => s.StudyTypeId);
            builder.Property(o => o.CompanyId)
                   .IsRequired();
            builder.Property(t => t.Title)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(d => d.Description)
                   .IsRequired()
                   .HasMaxLength(1500);
            builder.Property(m => m.MinSalary);
            builder.Property(m => m.MaxSalary);
            builder.Property(p => p.PublicationDate)
                   .IsRequired();
            builder.Property(m => m.MinAge);
            builder.Property(m => m.MaxAge);
            builder.Property(v => v.Vacancies);
            builder.Property(a => a.AvailabilityToTravel)
                   .IsRequired();
            builder.Property(a => a.AvailabilityChangeOfResidence)
                   .IsRequired();
            builder.Property(s => s.Status)
                   .IsRequired();

            builder.HasOne<JobOfferMode>(s => s.jobofferMode)
                   .WithMany()
                   .HasForeignKey(s => s.JobOfferModeId);

            builder.HasOne<StudyType>(s => s.studyType)
                   .WithMany()
                   .HasForeignKey(s => s.StudyTypeId);

            builder.HasOne<City>(s => s.city)
                   .WithMany()
                   .HasForeignKey(s => s.CityId);
            OfferData.SeedData(builder);
        }
    }
}
