using Microsoft.AspNetCore.Mvc;
using Project02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Controllers
{
    public class HomeController : Controller
    {

        private IAppointmentRepository repo;


        private AppointmentContext apptContext { get; set; }



        public HomeController(IAppointmentRepository temp, AppointmentContext x)
        {
            repo = temp;
            apptContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SignUp(Appointment appt)
        {

            return View("Form", appt);
        }

        [HttpPost]
        public IActionResult Form(Appointment apptForm)
        {

            apptContext.Add(apptForm);
            apptContext.SaveChanges();
            return View();
        }

    }
}
