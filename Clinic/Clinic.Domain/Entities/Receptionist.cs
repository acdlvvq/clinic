﻿namespace Clinic.Domain.Entities;

public class Receptionist : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public Guid AccountId { get; set; }
    public Account Account { get; set; } 
    public Guid OfficeId { get; set; }
    public Office Office { get; set; } 
}
