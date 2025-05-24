using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmLeaveTransaction1
{
    public long LeaveId { get; set; }

    public long LeaveTypeId { get; set; }

    public string? UserId { get; set; }

    public DateTime? LeaveFromDate { get; set; }

    public string? LeaveFromSession { get; set; }

    public DateTime? LeaveToDate { get; set; }

    public string? LeaveToSession { get; set; }

    public string? LeaveReason { get; set; }

    public long? NoOfLeaveDays { get; set; }

    public long? LeaveSanctionedDays { get; set; }

    public string? LeaveSanctionedDates { get; set; }

    public string? LeaveApprovedBy { get; set; }

    public string? SupportingDocuments { get; set; }

    public bool Active { get; set; }

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual UcLmMLeaveType1 LeaveType { get; set; } = null!;
}
