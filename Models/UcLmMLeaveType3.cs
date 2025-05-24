using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeaveType3
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

    public virtual ICollection<UcLmLeaveTransaction3> UcLmLeaveTransaction3s { get; set; } = new List<UcLmLeaveTransaction3>();

    public virtual ICollection<UcLmLeavesEligibilityForUser3> UcLmLeavesEligibilityForUser3s { get; set; } = new List<UcLmLeavesEligibilityForUser3>();

    public virtual ICollection<UcLmMLeavesEligibility3> UcLmMLeavesEligibility3s { get; set; } = new List<UcLmMLeavesEligibility3>();
}
