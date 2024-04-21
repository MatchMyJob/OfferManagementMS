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
    public class OfferQuery : IOfferQuery
    {

        private readonly AppDbContext _context;

        public OfferQuery(AppDbContext context)
        {
            _context = context;
        }
        
        public async Task<Paged<Offers>> RecoveryAll(Parameters parameters)
        {
            // HARDCODE - VERIFICAR ESTO
            IQueryable<Offers> offers = _context.Offer;
            /*  .Include(c => c.CityObject)
              .ThenInclude(p => p.ProvinceObject)
          .ThenInclude(c => c.CountryObject);*/

            //HARDCODE - VERFICIAR ESTO (EL ASYNC - AWAIT)
            return /*await*/ Paged<Offers>.ToPaged(offers, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Offers> RecoveryById(Guid id)
        {
            //HARDCODE - VERIFICAR ESTO
            Offers offer = await _context.Offer
                /*.Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)*/
                .FirstOrDefaultAsync(o => (o.OfferId == id));

            if (offer == null)
            {
                throw new NotFoundException("La oferta con el ID " + id + " no fue encontrada.");
            }
            return offer;
        }


    }
}
