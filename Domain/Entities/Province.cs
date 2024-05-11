using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Province
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public List<City> CityObjects { get; set; }
        public Country CountryObject { get; set; }
    }
}
