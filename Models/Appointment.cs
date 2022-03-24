using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class Appointment
    {
        [Key]
        [Required]
        public long AppointmentId { get; set; }

        public string GroupName { get; set; }

        public int GroupSize { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Time { get; set; }

        public string Date { get; set; }

        public bool Available { get; set; }

    }
}
