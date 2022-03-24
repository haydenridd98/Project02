using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Models
{
    public class EFSignUpRepository : ISignUpRepository
    {
        private SignUpContext _context { get; set; }
        public EFSignUpRepository(SignUpContext temp)
        {
            _context = temp;
        }

        public IQueryable<Appointment> appointments => _context.Appointments;
        public IQueryable<TimeSlot> timeSlots => _context.TimeSlots;

        public void InitializeTimeSlots()
        {
            _context.TimeSlots.RemoveRange(_context.TimeSlots);
        }

        public void AddAppointment(Appointment temp)
        {
            _context.Appointments.Add(temp);
            _context.SaveChanges();
        }

        public void Reserve(TimeSlot temp)
        {
            TimeSlot match = _context.TimeSlots.FirstOrDefault(t => t.Start == temp.Start);
            match.Open = false;
            _context.SaveChanges();
        }

        public void EditAppointment(Appointment apt)
        {
            Appointment temp = _context.Appointments.FirstOrDefault(a => a.AppointmentID == apt.AppointmentID);
            temp.GroupSize = apt.GroupSize;
            temp.GroupName = apt.GroupName;
            temp.Phone = apt.Phone;
            temp.Email = apt.Email;
            _context.SaveChanges();
        }

        public void DeleteAppointment(Appointment apt)
        {
            TimeSlot temp = _context.TimeSlots.FirstOrDefault(t => t.Start == apt.TimeSlot);
            temp.Open = true;
            _context.Appointments.Remove(apt);
            _context.SaveChanges();
        }
    }
}
