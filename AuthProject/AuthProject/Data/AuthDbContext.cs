using AuthProject.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace AuthProject.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
