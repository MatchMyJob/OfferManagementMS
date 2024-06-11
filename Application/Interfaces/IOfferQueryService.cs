using Application.DTO.Pagination;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IOfferQueryService : IQueryService<OfferResponse, Guid>
    {
        Task<Paged<OfferMinimalResponse>> GetAllOfferByFilters(
            int pageNumber, 
            int pageSize, 
            string? title, 
            Guid? company, 
            int? jobOfferMode, 
            int? jobOfferType, 
            int? province, 
            int? studyType, 
            List<int>? categories, 
            List<int>? skills, 
            bool availabilityToTravel, 
            bool availabilityChangeOfResidence, 
            DateTime? from, 
            DateTime? to
        );
    }
}
