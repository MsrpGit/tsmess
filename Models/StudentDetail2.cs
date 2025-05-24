using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class StudentDetail2
{
    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string? ClassName { get; set; }

    public string RollNo { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string? Mobile { get; set; }

    public string? EmailId { get; set; }

    public string? Dob { get; set; }

    public string? RegisteredDate { get; set; }

    public string Medium { get; set; } = null!;

    public string? AdmissionDate { get; set; }

    public string? Caste { get; set; }

    public string? BloodGroup { get; set; }

    public string? ContactNumber { get; set; }

    public string? IdentificationMarks1 { get; set; }

    public string? IdentificationMarks2 { get; set; }

    public string? Nationality { get; set; }

    public int? AdmittedClass { get; set; }

    public int? SectionAdmitted { get; set; }

    public string StudentType { get; set; } = null!;

    public string? PreviousSchool { get; set; }

    public string? PreviousClass { get; set; }

    public decimal TotalMarks { get; set; }

    public decimal Percentage { get; set; }

    public string? Board { get; set; }
}
