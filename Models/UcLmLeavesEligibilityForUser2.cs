using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmLeavesEligibilityForUser2
{
    public long LeaveEligUserId { get; set; }

    public long LeaveEligibilityId { get; set; }

    public int RoleId { get; set; }

    public long LeaveTypeId { get; set; }

    public string? UserId { get; set; }

    public decimal? NoOfLeaves { get; set; }

    public string? Remarks { get; set; }

    public bool Active { get; set; }

    public decimal BalanceLeaves { get; set; }

    public long? PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public decimal LeavesTaken { get; set; }

    public long CalenderYear { get; set; }

    public long CarryForwardLeaves { get; set; }

    public virtual UcLmMLeavesEligibility2 LeaveEligibility { get; set; } = null!;

    public virtual UcLmMLeaveType2 LeaveType { get; set; } = null!;

    public virtual WdiMRolemaster2 Role { get; set; } = null!;
}
