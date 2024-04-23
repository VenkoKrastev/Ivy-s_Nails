using IvysNails.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace IvysNails.Controllers
{
    public class CalendarController : Controller
    {
        private Dictionary<DateTime, string> calendar = new Dictionary<DateTime, string>();

        public CalendarController(IvyNailsDbContext context)
        {
            // Initialization of the calendar with free hours from 09:00 to 18:00
            DateTime startTime = DateTime.Today.AddHours(9);
            DateTime endTime = DateTime.Today.AddHours(19);

            for (DateTime time = startTime; time < endTime; time = time.AddHours(1))
            {
                calendar.Add(time, "Available");
            }

        }

        public ActionResult ViewCalendar()
        {
            return View(calendar);
        }

        public ActionResult ReserveTimeSlot(DateTime selectedTime)
        {
            if (calendar.ContainsKey(selectedTime) && calendar[selectedTime] == "Available")
            {
                calendar[selectedTime] = "Busy";
                ViewBag.Message = $"The hour {selectedTime.ToString("HH:mm")} has been successfully booked.";
            }
            else
            {
                ViewBag.Message = "The selected time slot is already taken or invalid. Please, try again.";
            }

            return RedirectToAction("ViewCalendar");
        }

    }
}
