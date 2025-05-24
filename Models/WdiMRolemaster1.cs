using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRolemaster1
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public long PartnerId { get; set; }

    public bool Status { get; set; }

    public int UserType { get; set; }

    public virtual ICollection<UcLmLeavesEligibilityForUser1> UcLmLeavesEligibilityForUser1s { get; set; } = new List<UcLmLeavesEligibilityForUser1>();

    public virtual ICollection<UcLmMLeavesEligibility1> UcLmMLeavesEligibility1s { get; set; } = new List<UcLmMLeavesEligibility1>();
}
