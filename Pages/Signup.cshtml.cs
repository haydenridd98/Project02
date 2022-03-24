using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project02.Models;

namespace Project02.Pages
{
    public class SignupModel : PageModel
    {
        private ITempleToursRepository repo { get; set; }

        public SignupModel (ITempleToursRepository temp)
        {
            repo = temp; 
        }

        public List<Appointment> Appointments;

        public void OnGet()
        {
            Appointments = repo.Appointments.ToList();
        }
        public void DeleteAppointment(Appointment a)
        {
            a.GroupName = null;
            a.GroupSize = 1;
            a.Email = null;
            a.Phone = null;
        }
    }
}
