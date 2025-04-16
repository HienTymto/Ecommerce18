using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Review
    {
        public int Id { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }

    public int ImageId { get; set; }
    public required Image Image { get; set; }

    public int Rating { get; set; } // 1 - 5
    public string Comment { get; set; } = "";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}