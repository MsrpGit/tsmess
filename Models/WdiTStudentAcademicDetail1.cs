using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentAcademicDetail1
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public long ClassId { get; set; }

    public long? Section { get; set; }

    public string RollNo { get; set; } = null!;

    public int GroupId { get; set; }

    public bool Status { get; set; }

    public string? FeeStatus { get; set; }

    public string ProfileStatus { get; set; } = null!;

    public int? Scholarshipid { get; set; }

    public string? Reason { get; set; }

    public long Secondlanguage { get; set; }

    public string? ElectiveSubjects { get; set; }

    public string? AcademicRemarks { get; set; }

    public DateTime? ReportingDate { get; set; }

    public short FeeGroupId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string PayType { get; set; } = null!;

    public string? Stream { get; set; }

    public virtual WdiMAcademicYearDetail1 AcademicYear { get; set; } = null!;
}
