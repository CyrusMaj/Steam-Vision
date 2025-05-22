using Microsoft.EntityFrameworkCore;
using SteamVision.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<SteamGame> SteamGames { get; set; }
}
