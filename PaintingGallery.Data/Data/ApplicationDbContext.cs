using Microsoft.EntityFrameworkCore;
using PaintingGallery.Data.Models;
namespace PaintingGallery.Data.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Artwork> Artworks { get; set; }

    protected override void OnModelCreating
    (
        ModelBuilder modelBuilder
    )
    {
        modelBuilder.Entity<Artwork>()
            .Property(a => a.Price)
            .HasPrecision(18, 2);
    }
}