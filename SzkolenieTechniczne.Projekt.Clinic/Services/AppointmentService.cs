using SzkolenieTechniczne.Projekt.Clinic.DTOs;
using SzkolenieTechniczne.Projekt.Clinic.Entities;
using SzkolenieTechniczne.Projekt.Clinic.Repository;

namespace SzkolenieTechniczne.Projekt.Clinic.Services {
    public class AppointmentService : IAppointmentService {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public List<AppointmentDTO> GetAllAppointments() {
            var appointments = _appointmentRepository.GetAll();
            return appointments.Select(a => new AppointmentDTO(a.Date)).ToList();
        }

        public void Create(AppointmentDTO appointmentDto) {
            Appointment appointment = new Appointment() {
                AppointmentId = Guid.NewGuid(),
                Date = appointmentDto.Date
            };
            _appointmentRepository.Create(appointment);
        }
    }
}
