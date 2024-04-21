using Application.DTO.Pagination;
using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

namespace Application.Interfaces
{
    public interface IGenericRepository
    {
        Task<T> Insert<T>(T entity) where T : class;

        Task Remove<T>(T entity) where T : class;

        Task<T> Update<T>(T entity) where T : class;

        Task SaveChanges();

    }
}
   

