using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFeeHeadGroupMaster3
{
    public short GroupId { get; set; }

    public string? GroupName { get; set; }

    public long PartnerId { get; set; }

    /// <summary>
    /// FULL PAYMENT OR INSTALLMENTS
    /// </summary>
    public string GroupType { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
