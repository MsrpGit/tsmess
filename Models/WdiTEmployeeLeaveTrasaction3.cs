using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmployeeLeaveTrasaction3
{
    public long EmployeLeaveId { get; set; }

    public string UserId { get; set; } = null!;

    public long EmployeeLeaveTypeId { get; set; }

    public decimal? LeaveDays { get; set; }

    public string? LeaveDates { get; set; }

    public decimal? LeaveSanctionedDays { get; set; }

    public string? LeaveSanctionedDates { get; set; }

    public string? Reason { get; set; }

    public string? SupportDocuments { get; set; }

    public string? Status { get; set; }

    public string? InchargeOrReplacement { get; set; }

    public string? EmployesToBeNotified { get; set; }

    public DateTime DateOfApply { get; set; }

    public DateTime? DateOfProcessed { get; set; }

    public long? AcademicYearId { get; set; }

    public string FromDate { get; set; } = null!;

    public string ToDate { get; set; } = null!;

    public string? ProcessedBy { get; set; }
}
