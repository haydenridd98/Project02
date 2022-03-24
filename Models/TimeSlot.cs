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
        public DateTime Start { get; set; }
        public bool Open { get; set; }
    }
}
