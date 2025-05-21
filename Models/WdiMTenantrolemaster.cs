using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTenantrolemaster
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string? RoleDisplayName { get; set; }

    public bool Status { get; set; }
}
