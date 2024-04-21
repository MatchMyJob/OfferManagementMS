using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.Query
{
    public class CategoryQuery : ICategoryQuery
    {

        private readonly AppDbContext _context;

        public CategoryQuery(AppDbContext context)
        {
            _context = context;
        }
        
        
        public async Task<Paged<Categories>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<Categories> categories = _context.Category;
            /*  .Include(c => c.CityObject)
              .ThenInclude(p => p.ProvinceObject)
          .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ Paged<Categories>.ToPaged(categories, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Categories> RecoveryById(int id)
        {
            //HARDCODE - VERIFICAR ESTO
            var categories = await _context.Category
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(c => (c.CategoryId == id));

            if (categories == null)
            {
                throw new NotFoundException("La categoria con el ID " + id + " no fue encontrada.");
            }
            return categories;
        }


    }
}
