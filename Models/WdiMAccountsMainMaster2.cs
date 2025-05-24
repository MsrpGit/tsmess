using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAccountsMainMaster2
{
    public int AccMainHeadGroupId { get; set; }

    public string? AccMainHeadName { get; set; }

    public long? PartnerId { get; set; }

    public bool Status { get; set; }

    public bool? IsPrimary { get; set; }

    public int? GroupId { get; set; }

    public string? Comments { get; set; }

    public string? GroupNature { get; set; }

    /// <summary>
    /// There are 28 pre-defined Groups in cloudcampus, out of which 15 are Primary Groups and 13 are Sub-Groups.
    /// </summary>
    public bool IsDefault { get; set; }
}
