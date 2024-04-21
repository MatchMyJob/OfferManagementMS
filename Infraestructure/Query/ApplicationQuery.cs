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
    public class ApplicationQuery : GenericRepository<Applications>
    { 

        private readonly AppDbContext _context;

        public ApplicationQuery(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<Paged<Applications>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<Applications> applications = _context.Application.Where(a => a.Status);
              /*  .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
            .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ Paged<Applications>.ToPaged(applications, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Applications> RecoveryById(int id)
        {
            //HARDCODE - VERIFICAR ESTO
            var application = await _context.Application
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(c => (c.ApplicationId == id) && (c.Status));

            if (application == null)
            {
                throw new NotFoundException("La Company con el ID " + id + " no fue encontrada.");
            }
            return application;
        }


    }
}
