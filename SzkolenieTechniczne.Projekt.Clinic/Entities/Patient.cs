﻿namespace SzkolenieTechniczne.Projekt.Clinic.Entities;

public class Patient {
    public int PatientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
}