using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMLessonPlan
{
    public long LessonPlanId { get; set; }

    /// <summary>
    /// Target Lesson Plan
    /// </summary>
    public int TlessonPlan { get; set; }

    /// <summary>
    /// Completed Lesson Plan
    /// </summary>
    public int ClessonPlan { get; set; }

    public string ClassName { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }
}
