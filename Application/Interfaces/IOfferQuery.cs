using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IOfferQuery
    {
        Task<Offers> RecoveryById(Guid id);

        Task<Paged<Offers>> RecoveryAll(Parameters parameters);
    }
    
}