namespace PaintingGallery.Data.Models;
public class Artwork
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string Medium { get; set; } = "";
    public string Dimensions { get; set; } = "";
    public decimal Price { get; set; }
    public string Status { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
}