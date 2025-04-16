using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Order
    {
        public int Id { get; set; }
    public int UserId { get; set; }
    public required User User { get; set; }

    public decimal TotalPrice { get; set; }
    public string PaymentStatus { get; set; } = "pending"; // paid, failed, pending
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public required Payment Payment { get; set; }
    public required ICollection<OrderItem> OrderItems { get; set; }
    }
}