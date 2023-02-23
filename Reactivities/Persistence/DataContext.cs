using Domain; //import for DbSet
using Microsoft.EntityFrameworkCore; // zainstalowana paczka .slqlite

namespace Persistence
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Activity> Activities {get; set;}
  }
}

