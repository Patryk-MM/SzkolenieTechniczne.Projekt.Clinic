using SzkolenieTechniczne.Projekt.Clinic.Entities;

namespace SzkolenieTechniczne.Projekt.Clinic.Repository {
    public class AppointmentRepositoryBase : IAppointmentRepository {

        private static List<Appointment> _appointments = new() {
            new Appointment { AppointmentId = 1, Date = new DateTime(2024, 06, 06, 12, 00, 00) },
            new Appointment { AppointmentId = 2, Date = new DateTime(2024, 06, 08, 14, 00, 00) },
        };
        public List<Appointment> GetAll() {
            return _appointments;
        }

        public void Create(Appointment appointment) {
            _appointments.Add(appointment);
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }
    }
}
