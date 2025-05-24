using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwStudentDetail4
{
    public string UserName { get; set; } = null!;

    public string? AdmissionNo { get; set; }

    public DateTime? AdmissionDate { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? Class { get; set; }

    public string? Section { get; set; }

    public string RollNo { get; set; } = null!;

    public string? Medium { get; set; }

    public string? Caste { get; set; }

    public string? Religion { get; set; }

    public string? FirstLanguage { get; set; }

    public string? SecondLanguage { get; set; }

    public string? Nationality { get; set; }

    public DateTime Dob { get; set; }

    public string? Gender { get; set; }

    public string? BloodGroup { get; set; }

    public string StudentType { get; set; } = null!;

    public string? PresentAddress { get; set; }

    public long EnrollNo { get; set; }

    public string ContactNo { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? Qualification { get; set; }

    public string? Occupation { get; set; }

    public string? MotherName { get; set; }

    public long? PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string? AdhaarNo { get; set; }

    public string? Elective1 { get; set; }

    public string? Elective2 { get; set; }

    public string? Elective3 { get; set; }

    public string? Elective4 { get; set; }
}
