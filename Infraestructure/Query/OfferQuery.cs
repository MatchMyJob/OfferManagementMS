﻿using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Query
{
    public class OfferQuery : IOfferQuery
    {

        private readonly AppDbContext _context;

        public OfferQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Offer>> RecoveryAll(Parameters parameters)
        {
            IQueryable<Offer> offers = _context.Offers.Where(o => o.Status)
                .Include(c => c.City)
                    .ThenInclude(p => p.Province)
                .Include(st => st.StudyType)
                .Include(os => os.OfferSkills)
                    .ThenInclude(s => s.Skill)
                .Include(jom => jom.JobOfferMode)
                .Include(oc => oc.OfferCategories)
                    .ThenInclude(c => c.Category)
                .Include(a => a.Applications)
                    .ThenInclude(ast => ast.ApplicationStatusType);

            return await Paged<Offer>.ToPagedAsync(offers, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Offer> RecoveryById(Guid id)
        {
            var offer = await _context.Offers
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
                .FirstOrDefaultAsync(u => (u.OfferId == id) && (u.Status));

            if (offer == null)
            {
                throw new NotFoundException("La oferta con el ID " + id + " no fue encontrada.");
            }
            return offer;
        }


    }
}
