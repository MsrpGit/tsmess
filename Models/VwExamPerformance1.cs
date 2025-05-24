using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwExamPerformance1
{
    public string? AdmissionNo { get; set; }

    public string? Name { get; set; }

    public string RollNo { get; set; } = null!;

    public string? ClassName { get; set; }

    public string? SectionName { get; set; }

    public string Examination { get; set; } = null!;

    public decimal? MaxMarks { get; set; }

    public decimal? SecuredMarks { get; set; }

    public decimal? Percentage { get; set; }

    public string? Grade { get; set; }

    public decimal? GradePoint { get; set; }

    public string? ClassRank { get; set; }

    public string? SectionRank { get; set; }

    public string Result { get; set; } = null!;

    public decimal? Cgpa { get; set; }

    public long? PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
