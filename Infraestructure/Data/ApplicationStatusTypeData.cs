﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data
{
    public class ApplicationStatusTypeData
    {
        public static void SeedData(EntityTypeBuilder<ApplicationStatusType> builder)
        {
            builder.HasData(
                new ApplicationStatusType { ApplicationStatusTypeId = 1, Name = "CV Visto" },
                new ApplicationStatusType { ApplicationStatusTypeId = 2, Name = "En Proceso" },
                new ApplicationStatusType { ApplicationStatusTypeId = 3, Name = "En Contacto" },
                new ApplicationStatusType { ApplicationStatusTypeId = 4, Name = "Finalizado" }
                );
        }
    }
}
