using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmployeeLeaveEligibility2
{
    public long EmployeeLeaveTypeId { get; set; }

    public string UserId { get; set; } = null!;

    public int LeaveTypeId { get; set; }

    public decimal DaysEligible { get; set; }

    public decimal CarryForward { get; set; }

    public DateTime EntryDate { get; set; }

    public decimal TotalLeaves { get; set; }

    public long? AcademicYearId { get; set; }
}
