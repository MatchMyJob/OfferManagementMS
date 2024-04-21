using Application.DTO.Error;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infraestructure.Command
{
    public class CategoryCommand : ICategoryCommand
    {
        private readonly AppDbContext _context;

        public CategoryCommand(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Categories> Insert(Categories entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

            var Application = new Categories(); // HARDCORE - CAMBIAR ESTO POR EL INSERT POSTA
            /*
            var Application = await _context.Application
                .Include(c => c.CityObject)
                .ThenInclude(p => p.ProvinceObject)
                .FirstOrDefaultAsync(u => (u.UserId == entity.UserId) && (u.Status));*/

            return Application;
        }

        public async Task Remove(int id)
        {
            var Application = await _context.Application
                .FirstOrDefaultAsync(u => (u.ApplicationId == id) && (u.Status));
            if (Application == null)
            {
                throw new NotFoundException("El Application con el ID " + id + " no fue encontrada.");
            }
            Application.Status = false;
            await _context.SaveChangesAsync();
        }

        public async Task<Categories> Update(int id, Categories entity)
        {
            var Category = await _context.Category
                .FirstOrDefaultAsync(u => (u.CategoryId == id));
            if (Category == null)
            {
                throw new NotFoundException("La Categoria con el ID " + id + " no fue encontrada.");
            }
            /*
            company.CityId = entity.CityId;
            company.CUIT = entity.CUIT;
            company.Phone = entity.Phone;
            company.BusinessName = entity.BusinessName;
            company.BusinessSector = entity.BusinessSector;
            company.Address = entity.Address;
            company.Website = entity.Website;
            company.Description = entity.Description;
            company.Logo = entity.Logo;*/

            await _context.SaveChangesAsync();

            return Category;
        }
    }
}
