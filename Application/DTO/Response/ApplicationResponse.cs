namespace Application.DTO.Response
{
    public class ApplicationResponse
    {
        public int ApplicationId { get; set; }
        public int ApplicationStatusTypeId { get; set; }
        public Guid UserId { get; set; }
        public Guid OfferId { get; set; }
        public DateTime ApplicationDate { get; set; }
        public bool Status { get; set; }
    }
