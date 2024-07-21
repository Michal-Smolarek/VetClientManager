using System.Collections.Generic;
using System.Threading.Tasks;
using VetClientManager.Models;

namespace VetClientManager.Repositories
{
    public interface IAppointmentRepository
    {
        Task<IEnumerable<Appointment>> GetAppointmentsAsync();
        Task<Appointment> GetAppointmentByIdAsync(int id);
        Task<int> AddAppointmentAsync(Appointment appointment);
        Task<int> UpdateAppointmentAsync(Appointment appointment);
        Task<int> DeleteAppointmentAsync(int id);
    }
}