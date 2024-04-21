using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cities
    {
        public int CityId { get; set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public ICollection<Offers> Offers { get; set; }
        public Provinces Province { get; set; }

    }
}
