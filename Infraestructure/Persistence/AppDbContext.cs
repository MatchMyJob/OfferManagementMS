using Domain.Entities;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new ApplicationConfig());
            modelBuilder.ApplyConfiguration(new ApplicationStatusTypeConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new JobOfferModeConfig());
            modelBuilder.ApplyConfiguration(new OfferCategoryConfig());
            modelBuilder.ApplyConfiguration(new OfferConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());
            modelBuilder.ApplyConfiguration(new SkillConfig());
            modelBuilder.ApplyConfiguration(new StudyTypeConfig());
        }
    }
}
