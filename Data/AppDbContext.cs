using Microsoft.EntityFrameworkCore;
using PlatformService.Models;

namespace PlatformService.Data
{
    public PlatformService.Data
    {
        public class AppDbContext: DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> opt) : base (opt_)
            {

            }

            public DbSet<Platform> Platforms { get; set; }
        }
    }
}