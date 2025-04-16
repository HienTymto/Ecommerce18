using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Payment
    {
        public int Id { get; set; }

    public int OrderId { get; set; }
    public required Order Order { get; set; }

    public string PaymentMethod { get; set; } = ""; // stripe, paypal, vnpay
    public string PaymentReference { get; set; } = ""; // mã giao dịch
    public string PaymentStatus { get; set; } = ""; // success, failed, pending
    public DateTime? PaidAt { get; set; }
    }
}