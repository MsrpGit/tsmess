using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMNotification
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    /// <summary>
    /// 0 ---- Unread  ,  1 - Read the Description.........
    /// </summary>
    public bool Status { get; set; }

    public DateTime CreatedDate { get; set; }
}
