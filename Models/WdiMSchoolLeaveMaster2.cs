using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSchoolLeaveMaster2
{
    public long LeaveId { get; set; }

    public DateTime LeaveDate { get; set; }

    public long SchoolId { get; set; }

    public string? LeaveTitle { get; set; }

    public string LeaveDescription { get; set; } = null!;

    public bool? Valid { get; set; }

    public long AcademicYearId { get; set; }
}
