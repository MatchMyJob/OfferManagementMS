namespace Domain.Entities
{
    public class Countries
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public List<Provinces> Provinces { get; set; }

    }
}
