using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class OrderItem
    {
         public int Id { get; set; }

    public int OrderId { get; set; }
    public required Order Order { get; set; }

    public int ImageId { get; set; }
    public required Image Image { get; set; }

    public decimal Price { get; set; }
    }
}