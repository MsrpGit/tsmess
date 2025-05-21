using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBatchAttendance
{
    public long BatchAttendaceId { get; set; }

    public string? UserId { get; set; }

    public DateTime? AbsentDate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public int? PeriodOrder { get; set; }
}
