using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OfferSkills
    {
        public int OfferSkillId { get; set; }
        public int SkillId { get; set; }
        public Guid OfferId { get; set; }
        public Skills Skill { get; set; }
        public Offers Offer { get; set; }
    }
}
