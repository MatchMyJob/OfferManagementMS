using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class CountryData
    {
        public static void SeedData(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country { CountryId = 1, Name = "Argentina" }
                );
        }
    }
}
