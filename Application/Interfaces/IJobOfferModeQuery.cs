using Application.DTO.Pagination;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IJobOfferModeQuery : IQuery<JobOfferModes, int>
    {
        Task<List<JobOfferModes>> RecoveryAll();

    }
    
}