using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobOfferModeQuery
    {
        Task<JobOfferModes> RecoveryById(Guid id);

        Task<Paged<JobOfferModes>> RecoveryAll(Parameters parameters);

    }
    
}