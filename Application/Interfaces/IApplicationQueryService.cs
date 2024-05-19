using Application.DTO.Response;

namespace Application.Interfaces
{
    public interface IApplicationQueryService : IQueryService<ApplicationCandidateResponse, int>
    {
    }
}
