using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Domain.Entities
{
    public class Offers
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
        public JobOfferModes JobOfferMode { get; set; }
        public ICollection<OfferCategories> OfferCategories { get; set; }
        public ICollection<Applications> Applications { get; set; }
        public ICollection<OfferSkills> OfferSkills { get; set; }
        public Cities City { get; set; }
        public StudyTypes StudyType { get; set; }
    }
}
