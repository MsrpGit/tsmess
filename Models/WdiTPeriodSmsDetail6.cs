using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPeriodSmsDetail6
{
    public long PeriodSmsDetailsId { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public string FacultyUserId { get; set; } = null!;

    public long SubjectId { get; set; }

    public DateTime AttDate { get; set; }

    public string? AbsentUserIds { get; set; }

    public bool SmsStatus { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string? Remarks { get; set; }
}
