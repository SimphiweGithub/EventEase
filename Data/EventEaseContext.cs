using Microsoft.EntityFrameworkCore;

public class EventEaseContext : DbContext
{
    public EventEaseContext(DbContextOptions<EventEaseContext> options)
        : base(options)
    {
    }

    public DbSet<Venue> Venues { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Booking> Bookings { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Fix cascade delete issue — make Venue-Booking relation Restrict
        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Venue)
            .WithMany()
            .HasForeignKey(b => b.VenueId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
