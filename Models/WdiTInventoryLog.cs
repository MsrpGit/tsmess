using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInventoryLog
{
    public long Logid { get; set; }

    public DateTime Logdate { get; set; }

    public string Action { get; set; } = null!;

    public string Actiontype { get; set; } = null!;

    public string? Actionfor { get; set; }

    public string Actionby { get; set; } = null!;

    public long? PartnerId { get; set; }
}
