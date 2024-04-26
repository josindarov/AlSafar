using AlSafar.Domain.Models.Client;
using AlSafar.Domain.Models.Employee;
using AlSafar.Domain.Models.Flight;
using AlSafar.Domain.Models.Hotel;
using AlSafar.Domain.Models.Tour;
using AlSafar.Domain.Models.TourCompany;
using Microsoft.EntityFrameworkCore;

namespace AlSafar.Infrastructure.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Flight> Flights { get; set; }
    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Tour> Tours { get; set; }
    public DbSet<TourCompany?> TourCompanies { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TourCompany>()
            .HasMany(o => o.Tours)
            .WithOne(o => o.TourCompany)
            .HasForeignKey(o => o.TourCompanyId);

        modelBuilder.Entity<Tour>()
            .HasMany(o => o.Clients)
            .WithOne(o => o.Tour)
            .HasForeignKey(o => o.TourId);

        modelBuilder.Entity<TourCompany>()
            .HasMany(o => o.Employees)
            .WithOne(o => o.TourCompany)
            .HasForeignKey(o => o.TourCompanyId);

        modelBuilder.Entity<Tour>()
            .HasOne(o => o.Flight)
            .WithMany(o => o.Tours)
            .HasForeignKey(o => o.FlightId);

        modelBuilder.Entity<Tour>()
            .HasOne(o => o.Hotel)
            .WithMany(o => o.Tours)
            .HasForeignKey(o => o.HotelId);
    }
}