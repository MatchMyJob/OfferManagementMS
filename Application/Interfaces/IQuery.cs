using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IQuery<T, ID> where T : class
    {
        Task<T> Insert(T entity);

        Task<T> RecoveryById(int id);

        Task<Paged<T>> RecoveryAll(Parameters parameters);

        Task Remove(T entity);

        Task SaveChanges();
    }
}