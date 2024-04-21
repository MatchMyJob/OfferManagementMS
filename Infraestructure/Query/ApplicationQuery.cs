using Application.DTO.Error;
using Application.DTO.Pagination;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
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

        public async Task<Paged<Applications>> RecoveryAll(Parameters parameters)
        {
            IQueryable<Applications> companies = _context.Companies.Where(a => a.Status)
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
            .ThenInclude(c => c.CountryObject);

            return await Paged<Applications>.ToPagedAsync(companies, parameters.PageNumber, parameters.PageSize);
        }

        public async Task<Applications> RecoveryById(int id)
        {
            var company = await _context.Companies
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(c => (c.CompanyId == id) && (c.Status));

            if (company == null)
            {
                throw new NotFoundException("La Company con el ID " + id + " no fue encontrada.");
            }
            return company;
        }
    }
}
