using Application.DTO.Pagination;

namespace Application.Interfaces
{
    public interface IJobOfferModeRepository<T> where T : class
    {
        Task<T> Insert(T entity);
        Task Remove(T entity);
        Task SaveChanges();
        Task <Paged<T>> RecoveryAll(Parameters parameters);
        Task<T> RecoveryById(int id);

    }
}
