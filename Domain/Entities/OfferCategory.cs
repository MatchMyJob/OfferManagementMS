using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OfferCategory
    {
        public int OfferCategoryId { get; set; }
        public Guid OfferId { get; set; }
        public int CategoryId { get;}
        public Offer offer { get; set; }
        public Category category { get; set; }
    }
}
