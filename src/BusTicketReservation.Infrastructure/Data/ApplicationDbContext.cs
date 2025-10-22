using BusTicketReservation.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusTicketReservation.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteStop> RouteStops { get; set; }
        public DbSet<BusSchedule> BusSchedules { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Ticket to BoardingStop relationship
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.BoardingStop)
                .WithMany()
                .HasForeignKey(t => t.BoardingStopId)
                .OnDelete(DeleteBehavior.Restrict);

            // Ticket to DroppingStop relationship
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.DroppingStop)
                .WithMany()
                .HasForeignKey(t => t.DroppingStopId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
