using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Download
    {
         public int Id { get; set; }

    public int UserId { get; set; }
    public required User User { get; set; }

    public int ImageId { get; set; }
    public required Image Image { get; set; }

    public DateTime DownloadedAt { get; set; } = DateTime.UtcNow;
    }
}