using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class Bulletin
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }
    }
}