using System.Collections;
using System.ComponentModel.DataAnnotations;
using SzkolenieTechniczne.Projekt.Clinic.Helpers;

namespace SzkolenieTechniczne.Projekt.Clinic.Entities;

public class Doctor {
    [Required]
    public Guid DoctorId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public Specialty Specialty { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}