using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Image
    {
        public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public string ImageUrl { get; set; } = "";
    public string ThumbnailUrl { get; set; } = "";
    public decimal Price { get; set; }
    public bool IsPublished { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public int CategoryId { get; set; }
    
    public required Category Category { get; set; }

    public int PhotographerId { get; set; }
    public required User Photographer { get; set; }

    public required ICollection<OrderItem> OrderItems { get; set; }
    public required ICollection<Download> Downloads { get; set; }
    public required ICollection<Review> Reviews { get; set; }
    }
}