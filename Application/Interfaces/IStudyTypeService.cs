using Application.DTO.Pagination;
using Application.DTO.Request;
using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IStudyTypeService
    {
        Task<StudyTypeResponse> Create(StudyTypeRequest request);
        Task DeleteById(int id);
        Task<Paged<StudyTypeResponse>> GetAll(int pageNumber, int pageSize);
        Task<StudyTypeResponse> GetById(int id);
        Task<StudyTypeResponse> Update(int id, StudyTypeRequest request);
    }
}
