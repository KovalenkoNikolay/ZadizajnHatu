using DataRepository.DbEntities.DesignStudio;
using DataRepository.DbEntities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataRepository
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<DesignStudio> DesignStudios { get; set; }

        public DbSet<DesignStudioPortfolio> DesignStudioPortfolio { get; set; }

        public DbSet<DesignStudioPrice> DesignStudioPrice { get; set; }

        public DbSet<DesignStudioPriceType> DesignStudioPriceType { get; set; }
    }
}
