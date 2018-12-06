using DataRepository.DbEntities.Tasks;
using DataRepository.DbEntities.Users;
using DataRepository.DbEntities.Works;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppUser> Designers { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Work> Works { get; set; }
    }
}
