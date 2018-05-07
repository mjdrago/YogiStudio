using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace YogiStudio.Models
{
    public class MasterSchedule
    {
        [Key]
        public int Id { get; set; }

        public virtual ClassDetail ClassId { get; set; }
        public int ClassDetailId { get; set; }

        public virtual Customer InstructorId { get; set; }
        public int CustomerId { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public int AppointmentLenghtInMinutes { get; set; }
    }
}