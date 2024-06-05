using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Projekt.Clinic.Entities {
    public class Appointment {
        public Guid AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Reason { get; set; }

        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
    }
}
