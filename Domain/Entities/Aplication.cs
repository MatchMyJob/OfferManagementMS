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
        public Offer Offer { get; set; }
        public ApplicationStatusType ApplicationStatusType { get; set; }
    }
}
