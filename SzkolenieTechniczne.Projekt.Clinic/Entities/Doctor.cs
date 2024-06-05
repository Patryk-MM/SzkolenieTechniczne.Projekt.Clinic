using SzkolenieTechniczne.Projekt.Clinic.Helpers;

namespace SzkolenieTechniczne.Projekt.Clinic.Entities;

public class Doctor {
    public int DoctorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Specialty Specialty { get; set; }
}