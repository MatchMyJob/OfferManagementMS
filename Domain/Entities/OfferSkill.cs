using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OfferSkill
    {
        public int OfferSkillId { get; set; }
        public int SkillId { get; set; }
        public int OfferId { get; set; }
        public Skill skill { get; set; }
        public Offer offer { get; set; }
    }
}
