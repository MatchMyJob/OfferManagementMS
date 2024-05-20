namespace Application.Interfaces
{
    public interface ICompanyApi : IBaseService
    {
        Task<T> GetById<T>(int id, string token);
    }
}
