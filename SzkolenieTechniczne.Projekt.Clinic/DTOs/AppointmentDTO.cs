using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Projekt.Clinic.DTOs {
    public class AppointmentDTO {
        public int AppointmentId { get; set; }
        public DateTime Date { get; set; }

        public AppointmentDTO() {
            
        }
        
        public AppointmentDTO(int appointmentId, DateTime date) {
            AppointmentId = appointmentId;
            Date = date;
        }
    }
}
