using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTDisciplineDetail1
{
    public long StudentDisciplineId { get; set; }

    public string DisciplineIssue { get; set; } = null!;

    public string DisciplineDescription { get; set; } = null!;

    public string ActionTaken { get; set; } = null!;

    public DateTime ReportedDate { get; set; }

    public string? ReportedBy { get; set; }

    public string StudentUserId { get; set; } = null!;

    public long AcademicYearId { get; set; }
}
