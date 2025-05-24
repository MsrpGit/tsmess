using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwStudentFeeDueDetail1
{
    public string? AdmissionNo { get; set; }

    public string RollNo { get; set; } = null!;

    public string? StudentName { get; set; }

    public string? Class { get; set; }

    public string? Section { get; set; }

    public string? FeeHeadName { get; set; }

    public string FatherName { get; set; } = null!;

    public string? Mobileno { get; set; }

    public string Mobile { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string? FeeFor { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? ConcessionAmount { get; set; }

    public decimal? AfterConcession { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? AmountDue { get; set; }
}
