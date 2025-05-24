using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCpuser
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Password { get; set; } = null!;

    /// <summary>
    /// 0-Registered User
    /// 1-Partner
    /// 2-Admin
    /// </summary>
    public int? UserType { get; set; }

    public DateTime? LastVisit { get; set; }

    /// <summary>
    /// -1 : InActive, 0 : Deleted, 1 : Active.
    /// </summary>
    public int Status { get; set; }

    public string? Permissions { get; set; }

    /// <summary>
    /// Sync Status default it will be False
    /// </summary>
    public bool SyncStatus { get; set; }

    public int SusertypeId { get; set; }

    public string? SuserType { get; set; }

    public string? Shahs { get; set; }

    public string? Sslat { get; set; }

    public bool IsFirstLogin { get; set; }

    public string? Reason { get; set; }
}
