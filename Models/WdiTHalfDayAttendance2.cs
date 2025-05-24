using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTHalfDayAttendance2
{
    public long HalfDayAttendanceId { get; set; }

    public string? UserId { get; set; }

    public int? ClassId { get; set; }

    public int? SectionId { get; set; }

    public DateTime? Date { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    /// <summary>
    /// 1--Morning Abscent ;  2 ---- AfterNoon Abscent
    /// </summary>
    public int? AttendanceType { get; set; }

    public string? Reason { get; set; }
}
