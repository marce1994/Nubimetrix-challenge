using Microsoft.EntityFrameworkCore;
using WebApi.Database.Entities;

namespace WebApi.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
