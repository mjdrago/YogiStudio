using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class Package
    {
        [Key]
        public int ID { get; set; }
        public string PackageType { get; set; }
        public double PackageCost { get; set; }
    }
}