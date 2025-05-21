using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAdjustFacultyPeriodTimetable
{
    public long Id { get; set; }

    public DateTime? Date { get; set; }

    public int PeriodId { get; set; }

    public int ClassId { get; set; }

    public int? Section { get; set; }

    public int? SubjectId { get; set; }

    public string UserId { get; set; } = null!;

    public string SourceUserId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Remarks { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
