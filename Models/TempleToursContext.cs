using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class TempleToursContext : DbContext
    {
        public TempleToursContext()
        {
        }
        public TempleToursContext(DbContextOptions<TempleToursContext> options) : base(options)
        {
        }

        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            for (int i = 0; i < 90; i++ )
            {
                DateTime nextDay = DateTime.Now.Date.AddDays(i);
                for (int h = 8; h < 21; h++)
                {
                    //if ()
                    //{ 
                    //    // figure out how to check if the date is already in the model 
                    //}
                    //else
                    {
                        mb.Entity<TimeSlot>().HasData(
                            new TimeSlot
                            {
                                Start = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, h, 0, 0)
                            });
                    }

                }
            }
            mb.Entity<TimeSlot>().HasData(
                new TimeSlot
                {
                    ID = 1,
                    Start = new DateTime(2022, 3, 24, 8, 0, 0)
                },
                new TimeSlot
                {
                    ID = 2, 
                    Start = new DateTime(2022, 3, 24, )
                }

                );

        }
    }
}
