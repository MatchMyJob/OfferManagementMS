namespace Domain.Entities
{
    public class Offer
    {
        public Guid OfferId { get; set; }
        public int CompanyId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int MinSalary { get; set; }
        public int MaxSalary { get; set; }
        public int JobOfferModeId { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CityId { get; set; }
        public int? MinAge { get; set; }
        public int? MaxAge { get; set; }
        public int Vacancies { get; set; }
        public bool AvailabilityToTravel { get; set; }
        public bool AvailabilityChangeOfResidence { get; set; }
        public int StudyTypeId { get; set; }
        public bool Status { get; set; }
        public JobOfferMode JobOfferMode { get; set; }
        public List<OfferCategory> OfferCategories { get; set; }
        public List<Aplication> Applications { get; set; }
        public List<OfferSkill> OfferSkills { get; set; }
        public City City { get; set; }
        public StudyType StudyType { get; set; }
    }
}
