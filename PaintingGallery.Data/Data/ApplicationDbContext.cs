using Microsoft.EntityFrameworkCore;
using PaintingGallery.Data.Models;
namespace PaintingGallery.Data.Data;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Artwork> Artworks { get; set; }

    public async Task<List<Artwork>> GetPublishedArtworkAsync()
    {
        return await Artworks
            .FromSqlRaw("EXEC sp_GetPublishedArtwork")
            .AsNoTracking()
            .ToListAsync();
    }
    public async Task<Artwork?> GetArtworkByIdAsync(int id)
    {
        return await Artworks
            .AsNoTracking()
            .FirstOrDefaultAsync(a => a.Id == id && a.Status == "Published");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Artwork>(entity =>
        {
            entity
                .Property(a => a.Price)
                .HasPrecision(18, 2);

            entity
                .Property(a => a.Status)
                .HasMaxLength(20)
                .IsRequired();

            entity
                .ToTable(t => t.HasCheckConstraint(
                    "CK_Artworks_Price_NonNegative",
                    "[Price] >= 0"));

            entity
                .ToTable(t => t.HasCheckConstraint(
                    "CK_Artworks_Status",
                    "[Status] IN ('Draft', 'Published')"));

            entity
                .HasIndex(a => new { a.Status, a.CreatedDate })
                .HasDatabaseName("IX_Artworks_Status_CreatedDate")
                .IsDescending(false, true);
        });
    }
}