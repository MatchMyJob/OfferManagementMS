using Application.DTO.Pagination;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Insert(T entity);

        Task<T> RecoveryById(int id);

        Task Remove(T entity);

        Task SaveChanges();

    }
}
   

