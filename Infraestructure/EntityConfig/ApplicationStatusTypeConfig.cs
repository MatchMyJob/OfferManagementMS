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
    public class ApplicationStatusTypeConfig : IEntityTypeConfiguration<ApplicationStatusType>

    {
        public void Configure(EntityTypeBuilder<ApplicationStatusType> builder)
        {
            builder.ToTable("ApplicationStatusType");
            builder.HasKey(s => s.ApplicationStatusTypeId);
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            ApplicationStatusTypeData.SeedData(builder);
        }
    }
}
