using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class Payment
    {
        [Key]
        public int ID { get; set; }
        public DateTime DatePurchased { get; set; }
        public DateTime DatePaymentReceived { get; set; }
        public double PurchaseTotal { get; set; }
    }
}