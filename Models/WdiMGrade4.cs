using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMGrade4
{
    public short Id { get; set; }

    public long? PartnerId { get; set; }

    public short MarksFrom { get; set; }

    public short MarksTo { get; set; }

    public string Grade { get; set; } = null!;

    public decimal? GradePoint { get; set; }

    public long AcademicYearId { get; set; }

    public bool? IsNonCourse { get; set; }
}
