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


        protected override void OnModelCreating(ModelBuilder mb)
        {
            int IdCounter = 1;
            int month = 3;
            int year = 2022;
            int day = 23;
            int hour = 8;

            while (day < 30)
            {
                while (hour < 21)
                {
                    mb.Entity<Appointment>().HasData(
                        new Appointment
                        {
                            AppointmentId = IdCounter,
                            GroupName = null,
                            GroupSize = 0,
                            Email = null,
                            PhoneNumber = null,
                            Time = hour.ToString(),
                            Date = month.ToString() + '/' + day.ToString() + '/' + year.ToString(),
                            Available = true
                        }
                    );
                    IdCounter++;
                    hour++;
                }
                day++;
                hour = 8;
            }
            
        }
    }
}
