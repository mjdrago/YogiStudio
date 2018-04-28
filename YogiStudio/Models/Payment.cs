using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class Payment
    {
        public DateTime DatePurchased { get; set; }
        public DateTime DatePaymentReceived { get; set; }
        public double PurchaseTotal { get; set; }
    }
}