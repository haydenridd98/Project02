using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project02.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ISignUpRepository _service { get; }



        public HomeController(ILogger<HomeController> logger, ISignUpRepository temp)
        {
            _logger = logger;
            _service = temp;
        }

        public IActionResult Index(int mydateparamater)
        {
            return View();
        }

        //Prepares the SignUp.cshtml page. 
        //Parameter: selectedDate is the date the user wishes to see timeslots for, or the current date if nothing is selected
        public IActionResult SignUp(string selectedDate = "")
        {
            DateTime selected;
            if (selectedDate == "")
            {
                selected = DateTime.Today;
            }
            else
            {
                selected = DateTime.Parse(selectedDate);
            }
            List<TimeSlot> timeSlotsToDisplay = _service.timeSlots.Where(t => t.Start.Date == selected.Date).OrderBy(t => t.Start).ToList();

            ViewBag.selectedDate = selected.ToShortDateString();
            ViewBag.timeSlots = timeSlotsToDisplay;

            return View();
        }


        //select timeslot 
        [HttpGet]
        public IActionResult Form(string startDate)
        {
            ViewBag.TimeSlot = startDate;

            return View();
        }

        // create appointment
        [HttpPost]
        public IActionResult Form(Appointment a, string TimeSlot)
        {
            if (ModelState.IsValid)
            {
                TimeSlot temp = _service.timeSlots.Where(t => t.Start == DateTime.Parse(TimeSlot)).First();
                _service.Reserve(temp);
                //a.TimeSlot = temp;
                _service.AddAppointment(a);
                return View("Index");
            }

            else
            {
                ViewBag.TimeSlot = TimeSlot;
                return View();
            }
        }

        public IActionResult ViewAppointments()
        {
            List<Appointment> temp = _service.appointments.ToList();
            ViewBag.appointments = temp;
            return View();
        }

        public IActionResult EditAppointment(IFormCollection form)
        {
            Appointment temp = _service.appointments.FirstOrDefault(a => a.AppointmentID == Convert.ToInt32(form["AppointmentID"]));
            temp.Email = form["Email"];
            temp.Phone = form["Phone"];
            temp.GroupSize = Convert.ToInt32(form["groupSize"]);
            temp.GroupName = form["groupName"];

            _service.EditAppointment(temp);

            return RedirectToAction("ViewAppointments");
        }
        public IActionResult DeleteApp(int AppointmentID)
        {
            Appointment temp = _service.appointments.FirstOrDefault(x => x.AppointmentID == AppointmentID);
            _service.DeleteAppointment(temp);
            return RedirectToAction("ViewAppointments");
        }

    }
}
