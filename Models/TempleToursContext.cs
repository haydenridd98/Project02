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
                    // figure this out
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
