using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;
using Azure.Core;
using Azure;

namespace Application.Interfaces
{
    public interface IApplicationService : IService<ApplicationRequest, ApplicationResponse>
    {
        Task<Response> Create(Request request);
        Task DeleteById(int id);
        Task<Paged<Response>> GetAll(int pageNumber, int pageSize);
        Task<Response> GetById(int id);
        Task<Response> Update(int id, ApplicationRequest request);
    }
}
