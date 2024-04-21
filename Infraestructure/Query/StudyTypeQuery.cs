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
    public class StudyTypeQuery : IStudyTypeQuery
    {

        private readonly AppDbContext _context;

        public StudyTypeQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Skills>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<Skills> skills = _context.Skill;
            /*  .Include(c => c.CityObject)
              .ThenInclude(p => p.ProvinceObject)
          .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ Paged<Skills>.ToPaged(skills, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<StudyTypes> RecoveryById(int id)
        {
            //HARDCODE - VERIFICAR ESTO
            var studyType = await _context.StudyType
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(s => (s.StudyTypeId == id));

            if (studyType == null)
            {
                throw new NotFoundException("El Tipo de Estudio con el ID " + id + " no fue encontrado.");
            }
            return studyType;
        }


    }
}
