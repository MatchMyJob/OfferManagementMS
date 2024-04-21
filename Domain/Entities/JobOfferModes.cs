using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class JobOfferModes
    {
        public int JobOfferModeId { get; set; }
        public string Name { get; set; }
        public ICollection<Offers> Offers { get; set; }

    }
}
