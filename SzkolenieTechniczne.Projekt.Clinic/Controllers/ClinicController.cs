using Microsoft.AspNetCore.Mvc;
using SzkolenieTechniczne.Projekt.Clinic.DTOs;
using SzkolenieTechniczne.Projekt.Clinic.Entities;
using SzkolenieTechniczne.Projekt.Clinic.Services;

namespace SzkolenieTechniczne.Projekt.Clinic.Controllers {
    public class ClinicController : Controller {
        private readonly IAppointmentService _appointmentService;

        public ClinicController(IAppointmentService appointmentService) {
            _appointmentService = appointmentService;
        }

        public IActionResult Index() {
            var appointments = _appointmentService.GetAllAppointments();
            return View(appointments);
        }

        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AppointmentDTO appointmentDto) {
            if (!ModelState.IsValid) return View(appointmentDto); // Return to the view with validation errors
            // Proceed with creating the appointment
            _appointmentService.Create(appointmentDto);
            return RedirectToAction("Index");

        }
    }
}