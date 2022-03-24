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
            int count = 0;
            for (int i = 0; i < 90; i++ )
            {
                
                DateTime nextDay = DateTime.Now.Date.AddDays(i);
                for (int h = 8; h < 21; h++)
                {
                    count += 1;
                    mb.Entity<TimeSlot>().HasData(
                        new TimeSlot
                        {
                            ID = count,
                            Start = new DateTime(nextDay.Year, nextDay.Month, nextDay.Day, h, 0, 0)
                        });                    
                }
            }   
        }
    }
}
