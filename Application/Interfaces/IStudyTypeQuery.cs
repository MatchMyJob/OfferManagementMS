using Domain.Entities;

namespace Application.Interfaces
{
    public interface IStudyTypeQuery : IQuery<StudyTypes, int>
    {
       Task<List<StudyTypes>> RecoveryAll();
    }
    
}