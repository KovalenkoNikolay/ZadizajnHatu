using DataRepository.DbEntities.DesignStudio;
using DataRepository.DbEntities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() : base() { }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<DesignStudio> DesignStudios { get; set; }
    }
}
