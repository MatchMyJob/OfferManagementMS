using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Provinces
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public ICollection<Cities> Cities { get; set; }
        public Countries Country { get; set; }

    }
}
