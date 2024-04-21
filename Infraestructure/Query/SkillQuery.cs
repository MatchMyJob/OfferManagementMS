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
    public class SkillQuery : ISkillQuery
    {

        private readonly AppDbContext _context;

        public SkillQuery(AppDbContext context)
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

        public async Task<Skills> RecoveryById(int id)
        {
            //HARDCODE - VERIFICAR ESTO
            var skill = await _context.Skill
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(s => (s.SkillId == id));

            if (skill == null)
            {
                throw new NotFoundException("El Skill con el ID " + id + " no fue encontrado.");
            }
            return skill;
        }


    }
}
