using DataRepository.DbEntities.Tasks;
using DataRepository.DbEntities.Users;
using Microsoft.EntityFrameworkCore;

namespace DataRepository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Designer> Designers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
