using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentLeaveTransaction2
{
    public long StudentLeaveId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? LeaveDays { get; set; }

    public DateTime? LeaveFromDate { get; set; }

    public string? LeaveFromValue { get; set; }

    public DateTime? LeaveToDate { get; set; }

    public string? LeaveToValue { get; set; }

    public string? LeaveDates { get; set; }

    public string? LeaveSanctionedDates { get; set; }

    public decimal? LeaveSanctionedDays { get; set; }

    public DateTime? LeaveSanctionedFromDate { get; set; }

    public string? LeaveSanctionedFromValue { get; set; }

    public DateTime? LeaveSanctionedToDate { get; set; }

    public string? LeaveSanctionedToValue { get; set; }

    public string? Reason { get; set; }

    public string? SupportDocuments { get; set; }

    public string? Status { get; set; }

    public DateTime DateOfApply { get; set; }

    public DateTime? DateOfProcessed { get; set; }

    public string? ProcessedBy { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? ProcessedReason { get; set; }
}
