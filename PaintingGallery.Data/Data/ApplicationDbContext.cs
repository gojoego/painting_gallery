using PaintingGallery.Data.Data;
using PaintingGallery.Data.Models;
using Microsoft.EntityFrameworkCore.DbContext;

namespace PaintingGallery.Data.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        
    }
    public DbSet<Artwork> Artworks { get; set; }
}