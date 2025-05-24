using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserAttendanceLookUp1
{
    public long UserAttendanceLookUpId { get; set; }

    public string? UserId { get; set; }

    public DateTime? Attendancedate { get; set; }

    public decimal? TotalHours { get; set; }

    public string? AttendanceType { get; set; }

    public long AcademicYearId { get; set; }

    public string DutyOn { get; set; } = null!;

    public string DutyOff { get; set; } = null!;
}
