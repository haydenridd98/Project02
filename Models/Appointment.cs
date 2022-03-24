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
        public TimeSlot TimeSlot { get; set; }

        [Required(ErrorMessage = "Enter a group name.")]
        public string GroupName { get; set; }

        [Required]
        [Range(1,15,ErrorMessage = "Groups must be between 1 and 15 people.")]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "Enter an email address.")]
        public string Email { get; set; }

        
        public string Phone { get; set; }
    }
}
