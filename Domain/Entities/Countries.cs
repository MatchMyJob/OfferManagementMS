using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Countries
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public ICollection<Provinces> Provinces { get; set; }

    }
}
