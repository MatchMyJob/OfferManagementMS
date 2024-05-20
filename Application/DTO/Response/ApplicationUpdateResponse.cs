namespace Application.DTO.Response
{
    public class ApplicationUpdateResponse
    {
        public int ApplicationId { get; set; }
        public string OfferTitle { get; set; }
        public ApplicantResponse Applicant { get; set; }
        public ApplicationStatusTypeResponse ApplicationStatusType { get; set; }
        public DateTime ApplicationDate { get; set; }
    }
}
