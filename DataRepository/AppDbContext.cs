using DataRepository.DbEntities.DesignStudio;
using DataRepository.DbEntities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataRepository
{
    public class AppDbContext : IdentityDbContext
    {
        private readonly IConfiguration _configuration;

        public AppDbContext(IConfiguration configuration) : base() {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                if (bool.Parse(_configuration.GetSection("UsePostgress").Value))
                {
                    optionsBuilder.UseNpgsql(_configuration.GetConnectionString("PostgressSQLConnectionString"));
                }
                else
                {
                    optionsBuilder.UseSqlServer(_configuration.GetConnectionString("MSSQLConnectionString"), b => b.UseRowNumberForPaging());
                }
            }
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<DesignStudio> DesignStudios { get; set; }
    }
}
