using IvysNails.Core.Models.ViewModels.Home;

namespace IvysNails.Core.Contracts
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<AppointmentServiceModel>> GetAvailableDates();

        Task<IEnumerable<AppointmentServiceModel>> BookAppointment(Infrastructure.Data.Models.Appointment appointment);




    }
}
