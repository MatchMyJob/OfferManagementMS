using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Azure.Core;
using Azure;

namespace Application.Interfaces
{
    public interface IApplicationService
    {
        Task<ApplicationResponse> Create(ApplicationRequest request);
        Task DeleteById(int id);
        Task<Paged<ApplicationResponse>> GetAll(int pageNumber, int pageSize);
        Task<ApplicationResponse> GetById(int id);
        Task<ApplicationResponse> Update(int id, ApplicationRequest request);
    }
}
