using IvysNails.Core.Contracts;
using IvysNails.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentController(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public IActionResult Index()
        {
            var availableDates = _appointmentRepository.GetAvailableDates();
            return View(availableDates);
        }

        [HttpPost]
        public IActionResult BookAppointment(Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }

            _appointmentRepository.BookAppointment(appointment);
            return RedirectToAction("Index");
        }
    }
}
