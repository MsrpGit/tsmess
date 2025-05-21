using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmpLeaveEligibilityTracker
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public int LeaveTypeId { get; set; }

    public decimal ExistingDaysEligible { get; set; }

    public decimal ModifiedDays { get; set; }

    public decimal CarryForward { get; set; }

    public DateTime EntryDate { get; set; }

    public decimal TotalLeaves { get; set; }

    public string? Reason { get; set; }

    public string? RefDocument { get; set; }

    public string? RecommendedBy { get; set; }

    public string? Authorisedby { get; set; }

    public string? ForwardedBy { get; set; }

    public string? ProcessedBy { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
