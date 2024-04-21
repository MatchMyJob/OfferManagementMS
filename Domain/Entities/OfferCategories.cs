using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OfferCategories
    {
        public int OfferCategoryId { get; set; }
        public Guid OfferId { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
        public Offers Offer { get; set; }
        public Categories Category { get; set; }
    }
}
