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
        public int AppointmentID { get; set; }

        [Required]
        public DateTime Start { get; set; }

        public string GroupName { get; set; }

        [Range(1,15,ErrorMessage = "Groups must be between 1 and 15 people.")]
        public int GroupSize { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
