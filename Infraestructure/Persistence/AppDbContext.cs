using Domain.Entities;
using Infraestructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Applications> Application { get; set; }
        public DbSet<ApplicationStatusTypes> ApplicationStatusType { get; set; }
        public DbSet<Categories> Category { get; set; }
        public DbSet<Cities> City { get; set; }
        public DbSet<Countries> Country { get; set; }
        public DbSet<JobOfferModes> JobOfferMode { get; set; }
        public DbSet<OfferCategories> OfferCategory { get; set; }
        public DbSet<Offers> Offer { get; set; }
        public DbSet<OfferSkills> OfferSkill { get; set; }
        public DbSet<Provinces> Provinces { get; set; }
        public DbSet<Skills> Skill { get; set; }
        public DbSet<StudyTypes> StudyType { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=OfferManagement;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new SkillConfig());
            modelBuilder.ApplyConfiguration(new JobOfferModeConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            modelBuilder.ApplyConfiguration(new ApplicationStatusTypeConfig());
            modelBuilder.ApplyConfiguration(new OfferCategoryConfig());
            modelBuilder.ApplyConfiguration(new ApplicationConfig());
            modelBuilder.ApplyConfiguration(new OfferSkillConfig());
            modelBuilder.ApplyConfiguration(new CountryConfig());
            modelBuilder.ApplyConfiguration(new ProvinceConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new StudyTypeConfig());
            modelBuilder.ApplyConfiguration(new OfferConfig());
        }
    }
}
