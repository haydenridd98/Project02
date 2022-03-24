using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Project02.Models
{
    public class SignUpContext : DbContext
    {
        public SignUpContext()
        {
        }

        public SignUpContext(DbContextOptions<SignUpContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(Settings.ConnectionString);
            }
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }


        public static class Settings
        {
            public static string ConnectionString { get; set; }
        }
    }
}
