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
    public class OfferCategoryConfig : IEntityTypeConfiguration<OfferCategory>

    {
        public void Configure(EntityTypeBuilder<OfferCategory> builder)
        {
            builder.ToTable("OfferCategory");
            builder.HasKey(s => s.OfferCategoryId);

            builder.HasOne<Category>(c => c.category)
                   .WithMany()
                   .HasForeignKey(fk => fk.CategoryId);

            builder.HasOne<Offer>(s => s.offer)
                   .WithMany()
                   .HasForeignKey(fk => fk.OfferId);
        }
    }
}
