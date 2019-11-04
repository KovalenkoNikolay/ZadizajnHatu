using DataRepository.DbEntities;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<PortfolioProject> PortfolioProjects { get; set; }
        public DbSet<WorkerReview> WorkerReviews { get; set; }
    }
}
