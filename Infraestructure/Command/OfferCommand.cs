using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Command
{
    public class OfferCommand : IOfferCommand
    {
        private readonly AppDbContext _context;

        public OfferCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Offers> Insert(Offers entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var company = await _context.Offer
                .Include(c => c.City)
                .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                .ThenInclude(ast => ast.ApplicationStatusType)
                .FirstOrDefaultAsync(u => (u.OfferId == entity.OfferId) && (u.Status));

            return company;
        }

        public async Task Remove(Guid id)
        {
            var company = await _context.Offer
                .FirstOrDefaultAsync(u => (u.OfferId == id) && (u.Status));
            if (company == null)
            {
                throw new NotFoundException("La Oferta con el ID " + id + " no fue encontrada.");
            }
            company.Status = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Offers> Update(Guid id, Offers entity)
        {
            var offerToUpdate = await _context.Offer
                .FirstOrDefaultAsync(p => p.OfferId == entity.OfferId);

            if (offerToUpdate == null)
            {
                throw new NotFoundException("La Oferta con el ID " + entity.OfferId + " no fue encontrada.");
            }
            _context.Entry(offerToUpdate).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();

            var updatedOffer = await _context.Offer
                .Include(c => c.City)
                .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                .ThenInclude(ast => ast.ApplicationStatusType)
                .FirstOrDefaultAsync(u => (u.OfferId == entity.OfferId) && (u.Status));

            return updatedOffer;
        }
    }
}
