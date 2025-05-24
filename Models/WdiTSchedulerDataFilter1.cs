using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSchedulerDataFilter1
{
    public long SchedulerDataId { get; set; }

    public long SchedulerId { get; set; }

    public string? FilterCondition { get; set; }

    public string ToAddressCondition { get; set; } = null!;
}
