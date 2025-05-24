using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcseclassWisePercentage2
{
    public int ClassId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal? Percentage { get; set; }

    public int? SubjectId { get; set; }

    public decimal? MaximumMarks { get; set; }

    public decimal? SecuredMarks { get; set; }

    public string? Grade { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string ClassName { get; set; } = null!;

    public string? SubjectName { get; set; }
}
