using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMLeaveMaster2
{
    public long LeaveId { get; set; }

    public DateTime? LeaveDate { get; set; }

    public string? LeaveDescription { get; set; }

    public long AcademicYearId { get; set; }
}
