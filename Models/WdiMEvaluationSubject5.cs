using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEvaluationSubject5
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public decimal? MaxMarks { get; set; }

    public decimal? MinMarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYear { get; set; }
}
