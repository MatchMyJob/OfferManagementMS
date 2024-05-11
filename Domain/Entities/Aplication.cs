using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Aplication
    {
        public int ApplicationId { get; set; }
        public int ApplicationStatusTypeId { get; set; }
        public Guid UserId { get; set; }
        public Guid OfferId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool Status { get; set; }
        public ApplicationStatusType applicationstatusType { get; set; }
        public Offer offer { get; set; }
    }
}
