﻿namespace Clinic.Domain.Entities;

public class Patient
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public string MiddleName { get; set; } 
    public DateOnly DateOfBirth { get; set; }
    public bool IsDeleted { get; set; }
    public Guid AccountId { get; set; }
    public Account Account { get; set; } 
    public ICollection<Appointment> Appointments { get; set; }
}
