using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRolemaster3
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public long PartnerId { get; set; }

    public bool Status { get; set; }

    public int UserType { get; set; }

    public virtual ICollection<UcLmLeavesEligibilityForUser3> UcLmLeavesEligibilityForUser3s { get; set; } = new List<UcLmLeavesEligibilityForUser3>();

    public virtual ICollection<UcLmMLeavesEligibility3> UcLmMLeavesEligibility3s { get; set; } = new List<UcLmMLeavesEligibility3>();
}
