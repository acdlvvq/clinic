﻿namespace Clinic.API.DTO.Receptionist;

public class Receptionist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public Guid OfficeId { get; set; }
}
