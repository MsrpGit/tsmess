using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeaveType4
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

    public virtual ICollection<UcLmLeaveTransaction4> UcLmLeaveTransaction4s { get; set; } = new List<UcLmLeaveTransaction4>();

    public virtual ICollection<UcLmLeavesEligibilityForUser4> UcLmLeavesEligibilityForUser4s { get; set; } = new List<UcLmLeavesEligibilityForUser4>();

    public virtual ICollection<UcLmMLeavesEligibility4> UcLmMLeavesEligibility4s { get; set; } = new List<UcLmMLeavesEligibility4>();
}
