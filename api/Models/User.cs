using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class User
    {
         public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string Role { get; set; } = "user"; // user, admin, photographer
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public required ICollection<Order> Orders { get; set; }
    public required ICollection<Download> Downloads { get; set; }
    public required ICollection<Review> Reviews { get; set; }
    public required ICollection<Image> UploadedImages { get; set; } // nếu là photographer
    }
}