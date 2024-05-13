using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOfferQuery
    {
        Task<Offer> RecoveryById(Guid id);

        Task<Paged<Offer>> RecoveryAll(Parameters parameters);
    }
    
}