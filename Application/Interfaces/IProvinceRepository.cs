using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IProvinceRepository
    {
        Task<T> Insert<T>(T entity);
        Task Remove<T>(T entity);
        Task SaveChanges();
        Task <Paged<T>> RecoveryAll<T>(Parameters parameters);
        Task<T> RecoveryById<T>(int id);

    }
}
