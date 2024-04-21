using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IApplicationRepository
    {
        Task<T> Insert<T>(T entity) where T : class;
        Task Remove<T>(T entity) where T : class;
        Task SaveChanges();
        Task <Paged<T>> RecoveryAll<T>(Parameters parameters);
        Task<T> RecoveryById<T>(int id);

    }
}
