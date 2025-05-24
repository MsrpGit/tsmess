using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class TempOrder
{
    public int Oid { get; set; }

    public string? Oname { get; set; }

    public int? Sid { get; set; }

    public string? Class { get; set; }

    public virtual TempOne? SidNavigation { get; set; }
}
