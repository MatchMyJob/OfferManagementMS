using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class JobOfferModeData
    {
        public static void SeedData(EntityTypeBuilder<JobOfferMode> builder)
        {
            builder.HasData(
                new JobOfferMode { JobOfferModeId = 1, Name = "Presencial" },
                new JobOfferMode { JobOfferModeId = 2, Name = "Hibrido" },
                new JobOfferMode { JobOfferModeId = 3, Name = "Remoto" }
                );
        }
    }
}
