using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Applications
    {
        public int ApplicationId { get; set; }
        public int ApplicationStatusTypeId { get; set; }
        public Guid UserId { get; set; }
        public Guid OfferId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool Status { get; set; }
        public Offers Offer { get; set; }
        public ApplicationStatusTypes ApplicationStatusType { get; set; }
    }
}
