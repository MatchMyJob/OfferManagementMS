using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Skills
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public ICollection<OfferSkills> OfferSkills { get; set; }
    }
}
