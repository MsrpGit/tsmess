using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLeaveType1
{
    public int Id { get; set; }

    public string LeaveType { get; set; } = null!;

    public string LeaveTypeName { get; set; } = null!;

    public decimal DaysEligibleMonth { get; set; }

    public decimal EligibleForYear { get; set; }

    public bool Encashable { get; set; }

    public bool CarryForward { get; set; }

    public long? AcademicYearId { get; set; }
}
