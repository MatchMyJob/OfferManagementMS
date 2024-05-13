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
    public class ApplicationQuery : IApplicationQuery
    {

        private readonly AppDbContext _context;

        public ApplicationQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Domain.Entities.Aplication>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<Domain.Entities.Aplication> applications = _context.Applications.Where(a => a.Status);
            /*  .Include(c => c.CityObject)
              .ThenInclude(p => p.ProvinceObject)
          .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ await Paged<Domain.Entities.Aplication>.ToPagedAsync(applications, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Domain.Entities.Aplication> RecoveryById(int id)
        {
            //HARDCODE - VERIFICAR ESTO
            var application = await _context.Applications
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(c => (c.ApplicationId == id) && (c.Status));

            if (application == null)
            {
                throw new NotFoundException("La Application con el ID " + id + " no fue encontrada.");
            }
            return application;
        }


    }
}
