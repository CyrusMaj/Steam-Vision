using Microsoft.EntityFrameworkCore;
using SteamVision.Models;

namespace SteamVision.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<SteamGame> SteamGames { get; set; }
    }
}


