using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ICategoryService
    {
        Task<CategoryResponse> Create(CategoryRequest request);
        Task DeleteById(int id);
        Task<Paged<CategoryResponse>> GetAll(int pageNumber, int pageSize);
        Task<CategoryResponse> GetById(int id);
       // Task<CategoryResponse> Update(int id, CategoryRequest request);
    }
}
