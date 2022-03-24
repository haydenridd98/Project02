using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class TimeSlot
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        public DateTime Start { get; set; }
        public int? AppointmentID { get; set; }

    }
}
