using Microsoft.EntityFrameworkCore;
using PaintingGallery.Data.Models;
namespace PaintingGallery.Data.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
    public DbSet<Artwork> Artworks { get; set; }
    
    public async Task<List<Artwork>> GetPublishedArtworkAsync()
    {
        return await Artworks
            .FromSqlRaw("EXEC sp_GetPublishedArtwork")
            .AsNoTracking()
            .ToListAsync();
    }
    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artwork>()
            .Property(a => a.Price)
            .HasPrecision(18, 2);
    }
}