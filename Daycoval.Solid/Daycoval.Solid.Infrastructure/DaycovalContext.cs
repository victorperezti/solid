using Microsoft.EntityFrameworkCore;

namespace Daycoval.Solid.Infrastructure;

public class DaycovalContext : DbContext
{
    public DaycovalContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
}