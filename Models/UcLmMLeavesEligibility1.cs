using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeavesEligibility1
{
    public long LeaveEligibilityId { get; set; }

    public int RoleId { get; set; }

    public long LeaveTypeId { get; set; }

    public decimal? NoOfLeaves { get; set; }

    public string? Remarks { get; set; }

    public bool Active { get; set; }

    public long? PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public long CalenderYear { get; set; }

    public string EmployeeType { get; set; } = null!;

    public virtual UcLmMLeaveType1 LeaveType { get; set; } = null!;

    public virtual WdiMRolemaster1 Role { get; set; } = null!;

    public virtual ICollection<UcLmLeavesEligibilityForUser1> UcLmLeavesEligibilityForUser1s { get; set; } = new List<UcLmLeavesEligibilityForUser1>();
}
