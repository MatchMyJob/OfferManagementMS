using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IJobOfferModeService
    {
        Task<JobOfferModeResponse> Create(JobOfferModeRequest request);
        Task DeleteById(int id);
        Task<Paged<JobOfferModeResponse>> GetAll(int pageNumber, int pageSize);
        Task<JobOfferModeResponse> GetById(int id);
        Task<JobOfferModeResponse> Update(int id, JobOfferModeRequest request);
    }
}
