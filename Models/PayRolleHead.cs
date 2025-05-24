using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class PayRolleHead
{
    public int HeadId { get; set; }

    public string? HeadName { get; set; }

    public string? HeadType { get; set; }

    public bool? Fixed { get; set; }

    public decimal? Amount { get; set; }

    public decimal? Percentage { get; set; }
}
