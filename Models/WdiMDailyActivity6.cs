using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMDailyActivity6
{
    public int ActivityId { get; set; }

    public string ActivityName { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string UserId { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string SubjectName { get; set; } = null!;

    public string CourseNyear { get; set; } = null!;

    public string Remarks { get; set; } = null!;

    public decimal NoofHours { get; set; }
}
