using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentLookup5
{
    public string UserId { get; set; } = null!;

    public string? AdmissionNo { get; set; }

    public string Fname { get; set; } = null!;

    public string? Lname { get; set; }

    public string StudentType { get; set; } = null!;

    public string? SiblingUserId { get; set; }

    public string? SiblingAdmissionNo { get; set; }

    public string? SiblingName { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public string? ParentTeacher { get; set; }
}
