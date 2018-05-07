using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class ClassDetail
    {
        [Key]
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
    }
}