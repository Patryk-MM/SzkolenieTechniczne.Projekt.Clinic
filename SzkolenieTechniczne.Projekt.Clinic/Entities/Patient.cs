using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Projekt.Clinic.Entities;

public class Patient {
    [Required]
    public Guid PatientId { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateTime BirthDate { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    
    public ICollection<Appointment> Appointments { get; set; }
}