using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAssessmentTransction2
{
    public long AssessId { get; set; }

    public string UserId { get; set; } = null!;

    public short ExamCode { get; set; }

    public short ActualMarks { get; set; }

    public string? Remarks { get; set; }

    public long AcademicYearId { get; set; }
}
