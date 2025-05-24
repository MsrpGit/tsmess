using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTHourlyEventAttendance1
{
    public long HourlyAttendaceId { get; set; }

    public int? PeriodOrder { get; set; }

    public string? UserId { get; set; }

    public DateTime? AbsentDate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public long? DepartmentId { get; set; }

    public long? SemesterId { get; set; }

    public int? BatchId { get; set; }

    public long? EventId { get; set; }
}
