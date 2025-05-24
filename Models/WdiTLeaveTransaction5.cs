using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLeaveTransaction5
{
    public long LeaveId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime LeaveAppliedDate { get; set; }

    public DateTime LeaveFrom { get; set; }

    public DateTime LeaveTo { get; set; }

    public string? LeaveReason { get; set; }

    public int? Status { get; set; }

    public string VerifiedBy { get; set; } = null!;

    public DateTime? VerifiedDate { get; set; }

    public long AcademicYearId { get; set; }
}
