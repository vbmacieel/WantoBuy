using Microsoft.EntityFrameworkCore;
using WantoBuy.Data.Entities;

namespace WantoBuy.Data.Database;

public class AppDatabase(DbContextOptions<AppDatabase> opts) : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
