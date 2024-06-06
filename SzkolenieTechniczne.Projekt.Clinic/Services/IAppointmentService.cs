using SzkolenieTechniczne.Projekt.Clinic.DTOs;

namespace SzkolenieTechniczne.Projekt.Clinic.Services {
    public interface IAppointmentService {
        List<AppointmentDTO> GetAllAppointments();
        void Create(AppointmentDTO appointmentDto);
        void Delete(int id);
    }
}
