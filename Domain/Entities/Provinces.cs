namespace Domain.Entities
{
    public class Provinces
    {
        public int ProvinceId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public List<Cities> Cities { get; set; }
        public Countries Country { get; set; }

    }
}
