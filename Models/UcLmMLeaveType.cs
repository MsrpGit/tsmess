using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeaveType
{
    public long LeaveTypeId { get; set; }

    public string? LeaveTypeName { get; set; }

    public string? LeaveTypeShortName { get; set; }

    public bool Active { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public bool SystemDefined { get; set; }

    public virtual ICollection<UcLmLeaveTransaction> UcLmLeaveTransactions { get; set; } = new List<UcLmLeaveTransaction>();

    public virtual ICollection<UcLmLeavesEligibilityForUser> UcLmLeavesEligibilityForUsers { get; set; } = new List<UcLmLeavesEligibilityForUser>();

    public virtual ICollection<UcLmMLeavesEligibility> UcLmMLeavesEligibilities { get; set; } = new List<UcLmMLeavesEligibility>();
}
