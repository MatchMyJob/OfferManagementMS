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
    public class JobOfferModeConfig : IEntityTypeConfiguration<JobOfferMode>

    {
        public void Configure(EntityTypeBuilder<JobOfferMode> builder)
        {
            builder.ToTable("JobOfferMode");
            builder.HasKey(s => s.JobOfferModeId);
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            JobOfferModeData.SeedData(builder);
        }
    }
}
