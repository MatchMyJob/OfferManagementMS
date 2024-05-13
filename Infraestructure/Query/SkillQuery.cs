using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class SkillQuery : ISkillQuery
    {

        private readonly AppDbContext _context;

        public SkillQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<List<Skills>> RecoveryAll()
        {
            List<Skills> skills = await _context.Skill
                .ToListAsync();
            return skills;
        }

        public Task<Paged<Skills>> RecoveryAll(Parameters parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<Skills> RecoveryById(int id)
        {
            var skill = await _context.Skill
                .FirstOrDefaultAsync(p => p.SkillId == id);

            if (skill == null)
            {
                throw new NotFoundException("El Skill con el ID " + id + " no fue encontrado.");
            }
            return skill;
        }


    }
}
