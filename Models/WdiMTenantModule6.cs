using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTenantModule6
{
    public int ModuleId { get; set; }

    public string ModuleName { get; set; } = null!;

    public string ModuleNature { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    /// <summary>
    /// Description Abou the Module
    /// </summary>
    public string? Remarks { get; set; }

    /// <summary>
    /// True---1  , false--0
    /// </summary>
    public bool? Status { get; set; }

    public double? Version { get; set; }

    public virtual ICollection<WdiMTicket5> WdiMTicket5s { get; set; } = new List<WdiMTicket5>();
}
