using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICategoryQuery : IQuery<Categories, int>
    {
        Task<List<Categories>> RecoveryAll();
    }
    
}