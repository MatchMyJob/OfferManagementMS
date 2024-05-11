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
    public class ApplicationConfig : IEntityTypeConfiguration<Aplication>

    {
        public void Configure(EntityTypeBuilder<Aplication> builder)
        {
            builder.ToTable("Application");
            builder.HasKey(a => a.ApplicationId);
            builder.Property(u => u.UserId)
                   .IsRequired();
            builder.Property(d => d.ApplicationDate)
                   .IsRequired();
            builder.Property(s => s.Status)
                   .IsRequired();

            builder.HasOne<Offer>(o => o.offer)
                   .WithMany()
                   .HasForeignKey(fk => fk.OfferId);
            builder.HasOne<ApplicationStatusType>(a => a.applicationstatusType)
                   .WithMany()
                   .HasForeignKey(fk => fk.ApplicationStatusTypeId);



        }
    }
}
