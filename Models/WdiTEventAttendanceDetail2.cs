using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEventAttendanceDetail2
{
    public long PeriodAttDetailsId { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public int PeriodOrder { get; set; }

    public string FacultyUserId { get; set; } = null!;

    public long SubjectId { get; set; }

    public DateTime AttDate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public int? BatchId { get; set; }

    public long? EventId { get; set; }

    public int? SemisterId { get; set; }
}
