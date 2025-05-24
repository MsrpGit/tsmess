using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSchedulerDetail3
{
    public long ScheduleDetId { get; set; }

    public long SchedulerId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool Status { get; set; }

    public bool EmailGenerated { get; set; }

    public DateTime SendDate { get; set; }

    public string? EmailContent { get; set; }
}
