using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public interface ITempleToursRepository
    {
        IQueryable<Appointment> Appointments { get; }

        public void SaveAppointment(Appointment a);
        public void CreateAppointment(Appointment a);
        public void DeleteAppointment(Appointment a);
    }
}
