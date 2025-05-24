using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeaveType2
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

    public virtual ICollection<UcLmLeaveTransaction2> UcLmLeaveTransaction2s { get; set; } = new List<UcLmLeaveTransaction2>();

    public virtual ICollection<UcLmLeavesEligibilityForUser2> UcLmLeavesEligibilityForUser2s { get; set; } = new List<UcLmLeavesEligibilityForUser2>();

    public virtual ICollection<UcLmMLeavesEligibility2> UcLmMLeavesEligibility2s { get; set; } = new List<UcLmMLeavesEligibility2>();
}
