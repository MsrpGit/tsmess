using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentStypendAmountDetail
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public string? AdmissionNo { get; set; }

    public long? ClassId { get; set; }

    public long? SectionId { get; set; }

    public long? ScholarshipId { get; set; }

    public decimal? Amount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? FeeFor { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? Partnerid { get; set; }

    public long? AcademicyearId { get; set; }

    public string Createdby { get; set; } = null!;

    public DateOnly Createddate { get; set; }

    public string? Modifiedby { get; set; }

    public DateTime? Modifieddate { get; set; }
}
