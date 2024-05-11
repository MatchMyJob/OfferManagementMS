using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class StudyTypeData
    {
        public static void SeedData(EntityTypeBuilder<StudyType> builder)
        {
            builder.HasData(
                new StudyType { JobOfferModeId = 1, Name = "Primaria"},
                new StudyType { JobOfferModeId = 2, Name = "Secundaria" },
                new StudyType { JobOfferModeId = 3, Name = "Terciario" },
                new StudyType { JobOfferModeId = 4, Name = "Universitario" },
                new StudyType { JobOfferModeId = 5, Name = "Posgrado" },
                new StudyType { JobOfferModeId = 6, Name = "Master" },
                new StudyType { JobOfferModeId = 7, Name = "Doctorado" }
                );
        }
    }
}
