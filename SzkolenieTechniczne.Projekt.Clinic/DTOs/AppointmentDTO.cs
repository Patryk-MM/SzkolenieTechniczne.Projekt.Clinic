using System.ComponentModel.DataAnnotations;

namespace SzkolenieTechniczne.Projekt.Clinic.DTOs {
    public class AppointmentDTO {
        [Required]
        public DateTime Date { get; set; }

        public AppointmentDTO() {
            
        }
        
        public AppointmentDTO(DateTime date)
        {
            Date = date;
        }
    }
}
