using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOfferQuery
    {
        Task<Offer> RecoveryById(Guid id);

        Task<Paged<Offer>> RecoveryAllOffers(
                Parameters parameters, 
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
                DateTime? to);
    }
    
}