using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentContext context { get; set; }

        public EFAppointmentRepository(AppointmentContext temp)
        {
            context = temp;
        }

        public IQueryable<Appointment> Appointments => context.Appointments;


        public void DeleteAppointment(Appointment a)
        {
            context.Remove(a);
            context.SaveChanges();
        }

        public void SaveAppointment(Appointment a)
        {
            context.Update(a);
            context.SaveChanges();
        }

    }
}
