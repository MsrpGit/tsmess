using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRolemaster6
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public long PartnerId { get; set; }

    public bool Status { get; set; }

    public int UserType { get; set; }

    public virtual ICollection<UcLmLeavesEligibilityForUser4> UcLmLeavesEligibilityForUser4s { get; set; } = new List<UcLmLeavesEligibilityForUser4>();

    public virtual ICollection<UcLmMLeavesEligibility4> UcLmMLeavesEligibility4s { get; set; } = new List<UcLmMLeavesEligibility4>();
}
