using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Projekt.Clinic.Entities {
    public class Appointment {

        [Required]
        public int AppointmentId { get; set; }

        public DateTime Date { get; set; }
    }
}
