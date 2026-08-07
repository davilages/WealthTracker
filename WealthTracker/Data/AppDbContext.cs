using Microsoft.EntityFrameworkCore;
using WealthTracker.Models;

namespace WealthTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Dividend> Dividends { get; set; }
    }
}
