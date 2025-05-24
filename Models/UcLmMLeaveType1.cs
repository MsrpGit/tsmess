using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeaveType1
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

    public virtual ICollection<UcLmLeaveTransaction1> UcLmLeaveTransaction1s { get; set; } = new List<UcLmLeaveTransaction1>();

    public virtual ICollection<UcLmLeavesEligibilityForUser1> UcLmLeavesEligibilityForUser1s { get; set; } = new List<UcLmLeavesEligibilityForUser1>();

    public virtual ICollection<UcLmMLeavesEligibility1> UcLmMLeavesEligibility1s { get; set; } = new List<UcLmMLeavesEligibility1>();
}
