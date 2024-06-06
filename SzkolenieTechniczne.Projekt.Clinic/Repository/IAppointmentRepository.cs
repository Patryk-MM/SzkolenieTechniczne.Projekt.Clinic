using SzkolenieTechniczne.Projekt.Clinic.Entities;

namespace SzkolenieTechniczne.Projekt.Clinic.Repository {
    public interface IAppointmentRepository {
        List<Appointment> GetAll();
        void Create(Appointment appointment);
        void Delete(int id);
    }
}
