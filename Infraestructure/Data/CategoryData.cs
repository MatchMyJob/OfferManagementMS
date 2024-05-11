using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class CategoryData
    {
        public static void SeedData(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { CategoryId = 1, Name = "Desarrollador"},
                new Category { CategoryId = 2, Name = "Vendedor" },
                new Category { CategoryId = 3, Name = "Administrativo" },
                new Category { CategoryId = 4, Name = "Analista" },
                new Category { CategoryId = 5, Name = "IT" },
                new Category { CategoryId = 6, Name = "Asesor" },
                new Category { CategoryId = 7, Name = "Comercio" }
                );

        }
    }
}
