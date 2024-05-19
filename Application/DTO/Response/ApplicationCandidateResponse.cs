namespace Application.DTO.Response
{
    public class ApplicationCandidateResponse
    {
        public int ApplicationId { get; set; }
        public string OfferTitle { get; set; }
        public string Company { get; set; }
        public int ApplicationQuantity { get; set; }
        public ApplicationStatusTypeResponse ApplicationStatusType { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
