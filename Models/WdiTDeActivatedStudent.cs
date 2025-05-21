using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTDeActivatedStudent
{
    public long Id { get; set; }

    public string AdmissionNo { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string Name { get; set; } = null!;

    public long ClassId { get; set; }

    public long? SectionId { get; set; }

    public string? RollNo { get; set; }

    public int? GroupId { get; set; }

    public int? Scholarshipid { get; set; }

    public long? Secondlanguage { get; set; }

    public string? ElectiveSubjects { get; set; }

    public DateTime? ReportingDate { get; set; }

    public short? FeeGroupId { get; set; }

    public string? Stream { get; set; }

    public string? Branches { get; set; }

    public string Status { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Mobile { get; set; }

    public string? Reason { get; set; }

    public decimal DueAmount { get; set; }
}
