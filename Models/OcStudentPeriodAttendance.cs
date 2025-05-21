using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class OcStudentPeriodAttendance
{
    public long StudentPeriodAttnId { get; set; }

    public string? UserId { get; set; }

    public int? PeriodOrder { get; set; }

    public long? ClassEventId { get; set; }

    public DateTime? AttDate { get; set; }

    public DateTime CreatedDate { get; set; }
}
