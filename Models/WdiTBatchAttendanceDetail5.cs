using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBatchAttendanceDetail5
{
    public long BatchAttDetailsId { get; set; }

    public long BatchId { get; set; }

    public int PeriodOrder { get; set; }

    public string FacultyUserId { get; set; } = null!;

    public long SubjectId { get; set; }

    public DateTime AttDate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
