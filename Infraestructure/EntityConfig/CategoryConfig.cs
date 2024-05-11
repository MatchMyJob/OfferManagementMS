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
    public class CategoryConfig : IEntityTypeConfiguration<Category>

    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(s => s.CategoryId);
            builder.Property(s => s.Name)
                   .IsRequired()
                   .HasMaxLength(50);
            CategoryData.SeedData(builder);
        }
    }
}
