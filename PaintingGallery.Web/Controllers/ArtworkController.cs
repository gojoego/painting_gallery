using Microsoft.AspNetCore.Mvc;
using PaintingGallery.Data.Data;

namespace PaintingGallery.Web.Controllers;
public class ArtworkController : Controller
{
    private readonly ApplicationDbContext _context;
    public ArtworkController(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var artworks = await _context.GetPublishedArtworkAsync();
        return View(artworks);
    }
}