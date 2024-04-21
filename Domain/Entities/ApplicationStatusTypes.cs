using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationStatusTypes
    {
        public int ApplicationStatusTypeId { get; set; }
        public string Name { get; set; }
        public ICollection<Applications> Applications { get; set; }
    }
}
