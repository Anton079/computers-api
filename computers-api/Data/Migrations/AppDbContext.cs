using computers_api.Computers.Models;
using Microsoft.EntityFrameworkCore;

namespace computers_api.Data.Migrations
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Computer> Computers { get; set; }
    }
}
