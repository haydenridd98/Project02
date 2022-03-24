using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public interface ISignUpRepository
    {
        IQueryable<Appointment> appointments { get; }
        IQueryable<TimeSlot> timeSlots { get; }
        void InitializeTimeSlots();
        void AddAppointment(Appointment temp);
        void Reserve(TimeSlot temp);
        void EditAppointment(Appointment app);
        void DeleteAppointment(Appointment app);
    }
}
