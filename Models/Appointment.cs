﻿using System;
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

        [Required]
        public string GroupName { get; set; }

        [Required]
        public int GroupSize { get; set; }

        [Required]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
    }
}
