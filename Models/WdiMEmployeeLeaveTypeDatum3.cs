using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEmployeeLeaveTypeDatum3
{
    public long EmployeeLeaveTypeDataId { get; set; }

    public long? EmployeeLeaveTypeId { get; set; }

    public decimal? TotalDaysEligible { get; set; }

    public decimal? CarryForward { get; set; }

    public string? ForMonth { get; set; }

    public DateTime? EntryDate { get; set; }

    public long AcademicYearId { get; set; }
}
