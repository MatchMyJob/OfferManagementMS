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
    public class JobOfferModeQuery : IJobOfferModeQuery
    {

        private readonly AppDbContext _context;

        public JobOfferModeQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<JobOfferModes>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<JobOfferModes> JobOfferModes = _context.JobOfferMode;
            /*  .Include(c => c.CityObject)
              .ThenInclude(p => p.ProvinceObject)
          .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ Paged<JobOfferModes>.ToPaged(JobOfferModes, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<JobOfferModes> RecoveryById(Guid id)
        {
            //HARDCODE - VERIFICAR ESTO
            var JobOfferMode = await _context.JobOfferMode.FirstOrDefaultAsync();
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
            //    .FirstOrDefaultAsync(s => (s.JobOfferModeId == id));

            if (JobOfferMode == null)
            {
                throw new NotFoundException("El JobOfferMode con el ID " + id + " no fue encontrado.");
            }
            return JobOfferMode;
        }


    }
}
