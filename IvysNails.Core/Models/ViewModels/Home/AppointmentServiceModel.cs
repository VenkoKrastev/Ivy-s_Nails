using IvysNails.Infrastructure.Data.Models;

namespace IvysNails.Core.Models.ViewModels.Home
{
    public class AppointmentServiceModel : Appointment
    {
        public int Id { get; set; }

        public string ServiceName { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public string Email { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public string AvailableDates { get; set; } = string.Empty;

        public IEnumerable<DateTime> Dates { get; set; }


    }
}
