using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmpCompleteLeaveTrasaction
{
    public long EmpLeaveTransId { get; set; }

    public string UserId { get; set; } = null!;

    public long? EmployeeLeaveId { get; set; }

    public DateTime LeaveDate { get; set; }

    public string DaySegment { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedDate { get; set; }
}
