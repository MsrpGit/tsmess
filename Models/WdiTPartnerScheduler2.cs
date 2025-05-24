using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPartnerScheduler2
{
    public long SchedulerId { get; set; }

    public long PartnerId { get; set; }

    public string SchedulerFor { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public short Duration { get; set; }

    public string SchedulerType { get; set; } = null!;

    public bool Status { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
