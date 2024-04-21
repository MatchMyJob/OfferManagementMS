using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IProvinceService
    {
        Task<ProvincesResponse> Create(ProvincesRequest request);
        Task DeleteById(int id);
        Task<Paged<ProvincesResponse>> GetAll(int pageNumber, int pageSize);
        Task<ProvincesResponse> GetById(int id);
     //   Task<ProvincesResponse> Update(int id, ProvincesRequest request);
    }
}
