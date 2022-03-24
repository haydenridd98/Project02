using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project02.Models
{
    public class AppointmentContext : DbContext
    {
        public AppointmentContext()
        {
        }

        public AppointmentContext(DbContextOptions<AppointmentContext> options)
            : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }


        //protected override void OnModelCreating(ModelBuilder mb)
        //{
        //    mb.Entity<Appointment>().HasData(
        //        new Appointment
        //        {
        //            AppointmentId = 1,
        //            GroupName = null,
        //            GroupSize = 0,
        //            Email = null,
        //            PhoneNumber = null,
        //            Time = "8 A.M.",
        //            Date = "Mar 22, 2022"
        //        }
        //    );
        //}


    }
}
