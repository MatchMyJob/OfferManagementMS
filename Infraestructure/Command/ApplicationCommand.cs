using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class ApplicationCommand : IApplicationCommand
    {
        private readonly AppDbContext _context;

        public ApplicationCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Aplication> Insert(Aplication entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var applicationAdded = await _context.Applications
                .Include(a => a.ApplicationStatusType)
                .Include(a => a.Offer)
                    .ThenInclude(o => o.City)
                        .ThenInclude(c => c.Province)
                .Include(a => a.Offer)
                    .ThenInclude(st => st.StudyType)
                .Include(a => a.Offer)
                    .ThenInclude(os => os.OfferSkills)
                        .ThenInclude(s => s.Skill)
                .Include(a => a.Offer)
                    .ThenInclude(jom => jom.JobOfferMode)
                .Include(a => a.Offer)
                    .ThenInclude(oc => oc.OfferCategories)
                        .ThenInclude(c => c.Category)
                .FirstOrDefaultAsync(a => (a.ApplicationId == entity.ApplicationId) && (a.Status));

            return entity;
        }

        public async Task Remove(int id)
        {
            var application = await _context.Applications
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            if (application == null) { throw new NotFoundException("La application con el ID " + id + " no fue encontrada.");}

            _context.Applications.Remove(application);

            await _context.SaveChangesAsync();
        }

        public async Task<Aplication> Update(int id, Aplication entity)
        {
            var application = await _context.Applications
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            if (application == null) { throw new NotFoundException("La application con el ID " + id + " no fue encontrada."); }

            _context.Entry(application).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            var applicationUpdated = await _context.Applications
                .Include(a => a.ApplicationStatusType)
                .FirstOrDefaultAsync(a => (a.ApplicationId == id) && (a.Status));

            return applicationUpdated;
        }
    }
}
