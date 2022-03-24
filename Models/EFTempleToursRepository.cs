using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class EFTempleToursRepository : ITempleToursRepository
    {
        private TempleToursContext context { get; set; }

        public EFTempleToursRepository (TempleToursContext temp)
        {
            context = temp;
        }

        public IQueryable<Appointment> Appointments => context.Appointments;

        public void CreateAppointment(Appointment a)
        {
            context.Add(a);
            context.SaveChanges();
        }

        public void DeleteAppointment(Appointment a)
        {
            a.GroupName = null;
            a.GroupSize = 1;
            a.Email = null;
            a.Phone = null;
            context.Update(a);
            context.SaveChanges();
        }

        public void SaveAppointment(Appointment a)
        {
            context.SaveChanges();
        }
    }
}
