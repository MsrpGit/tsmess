using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEvaluationMark2
{
    public long MarksId { get; set; }

    public int? ApplicationNo { get; set; }

    public int? SubjectId { get; set; }

    public decimal? ActualMarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
