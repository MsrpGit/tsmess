using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMRolemaster2
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public long PartnerId { get; set; }

    public bool Status { get; set; }

    public int UserType { get; set; }

    public virtual ICollection<UcLmLeavesEligibilityForUser2> UcLmLeavesEligibilityForUser2s { get; set; } = new List<UcLmLeavesEligibilityForUser2>();

    public virtual ICollection<UcLmMLeavesEligibility2> UcLmMLeavesEligibility2s { get; set; } = new List<UcLmMLeavesEligibility2>();
}
