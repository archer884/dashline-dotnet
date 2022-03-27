using Dashline.Core.Entity;
using Microsoft.EntityFrameworkCore;

namespace Dashline.Core.Context;

public class ApplicationContext : DbContext
{
    // FIXME: Why the hell should all of this be nullable?!
    public DbSet<Pilot> Pilots { get; set; }
    public DbSet<Plan> Legs { get; set; }
    public DbSet<Flight> Flights { get; set; }

    public string DbPath { get; }

    // FIXME: For right now, this is based on sqlite
#pragma warning disable CS8618 // This is Entity Framework's damn fault.
    public ApplicationContext()
#pragma warning restore CS8618 // This is Entity Framework's damn fault.
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "dashline.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Pilot>().ToTable(nameof(Pilot));
        builder.Entity<Plan>().ToTable(nameof(Plan));
        builder.Entity<Flight>().ToTable(nameof(Flight));
    }
}
