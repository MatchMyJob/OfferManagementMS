using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface ISkillService
    {
        Task<SkillResponse> Create(SkillRequest request);
        Task DeleteById(int id);
        Task<Paged<SkillResponse>> GetAll(int pageNumber, int pageSize);
        Task<SkillResponse> GetById(int id);
      //  Task<SkillResponse> Update(int id, SkillRequest request);
    }
}
