using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Ttemp
{
    public long? ScheduleId { get; set; }

    public int? SubjectId { get; set; }

    public int? Section { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
