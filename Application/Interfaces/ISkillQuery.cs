using Domain.Entities;

namespace Application.Interfaces
{
    public interface ISkillQuery : IQuery<Skills, int>
    {
        Task<List<Skills>> RecoveryAll();
    }
    
}