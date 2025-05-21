using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmpDeductionLeaveTrasaction
{
    public long LeaveTransId { get; set; }

    public string UserId { get; set; } = null!;

    public long? EmployeeLeaveId { get; set; }

    public long? EmployeeLeaveTypeId { get; set; }

    public decimal ActualNoofDays { get; set; }

    public long? DeductionHeadId { get; set; }

    public decimal DeductionDays { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string? ModifiedDate { get; set; }
}
