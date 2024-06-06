using SzkolenieTechniczne.Projekt.Clinic.Data;
using SzkolenieTechniczne.Projekt.Clinic.Entities;

namespace SzkolenieTechniczne.Projekt.Clinic.Repository;

public class AppointmentRepository : IAppointmentRepository {
    private readonly ApplicationDbContext _dbContext;

    public AppointmentRepository(ApplicationDbContext dbContext) {
        _dbContext = dbContext;
    }
    public List<Appointment> GetAll() {
        return _dbContext.Appointments.ToList();
    }

    public void Create(Appointment appointment) {
        _dbContext.Appointments.Add(appointment);
        _dbContext.SaveChanges();
    }

    public void Delete(int id) {
        var appointment = _dbContext.Appointments.Find(id);
        _dbContext.Appointments.Remove(appointment);
        _dbContext.SaveChanges();
    }
}