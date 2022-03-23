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

        public HomeController(IAppointmentRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult SignUp()
        {
            return View();
        }




        [HttpGet]
        public IActionResult Form()
        {
            return View(new Appointment());
        }


        [HttpPost]
        public IActionResult Form(Appointment appt)
        {

            return View("/Home/SignUp");
        }



    }
}
