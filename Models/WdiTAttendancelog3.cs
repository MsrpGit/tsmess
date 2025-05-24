using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAttendancelog3
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long EnrollNo { get; set; }

    public long MachineNo { get; set; }

    public DateTime? Date { get; set; }

    public string? RecordTime { get; set; }
}
