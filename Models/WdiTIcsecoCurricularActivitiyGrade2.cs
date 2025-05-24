using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsecoCurricularActivitiyGrade2
{
    public long CoCurricularActivitiyGradeId { get; set; }

    public string? UserId { get; set; }

    public string? Grade { get; set; }

    public int? TermId { get; set; }

    public long? CoCurricularActivityId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
