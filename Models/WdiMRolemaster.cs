using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRolemaster
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public long PartnerId { get; set; }

    public bool Status { get; set; }

    public int UserType { get; set; }

    public virtual ICollection<UcLmLeavesEligibilityForUser> UcLmLeavesEligibilityForUsers { get; set; } = new List<UcLmLeavesEligibilityForUser>();

    public virtual ICollection<UcLmMLeavesEligibility> UcLmMLeavesEligibilities { get; set; } = new List<UcLmMLeavesEligibility>();
}
