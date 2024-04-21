using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.EntityConfig
{
    public class CategoryConfig : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(i => i.CategoryId);
            builder.Property(i => i.CategoryId).ValueGeneratedOnAdd();
            builder.Property(n => n.Name).IsRequired();
        }
    }
}
