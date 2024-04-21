using Application.DTO.Pagination;
using Application.Interfaces;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly AppDbContext _context;
      
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<T> Insert<T>(T entity) where T : class
        {
            await _context.AddAsync(entity);
            await SaveChanges();
            return entity;
        }

        public async Task<T> Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Remove<T>(T entity) where T : class
        {
            _context.Remove(entity);
            await SaveChanges();
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }


    }
}
