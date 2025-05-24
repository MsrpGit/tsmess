using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLessonPlanner3
{
    public long LessonId { get; set; }

    public string LessonTitle { get; set; } = null!;

    public string? Topics { get; set; }

    public long SubjectId { get; set; }

    public long ClassId { get; set; }

    public long? Section { get; set; }

    public long PartnerId { get; set; }

    public DateTime PeriodFrom { get; set; }

    public DateTime PeriodTo { get; set; }

    public byte PeriodsPlanned { get; set; }

    public byte PeriodsCompleted { get; set; }

    public string FacultyId { get; set; } = null!;

    /// <summary>
    /// 0 - Pending, 1 - Progress, 2 - Completed
    /// </summary>
    public short Status { get; set; }

    public decimal? Percentage { get; set; }

    public string? Remarks { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long AcademicYearId { get; set; }
}
