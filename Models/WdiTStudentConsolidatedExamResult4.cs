using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentConsolidatedExamResult4
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public int ClassId { get; set; }

    public long SectionId { get; set; }

    public string UserId { get; set; } = null!;

    public long ExaminationId { get; set; }

    public decimal? TotalSecuredMarks { get; set; }

    public string? Grade { get; set; }

    public decimal? GradePoint { get; set; }

    public int? ClassRank { get; set; }

    public int? SectionRank { get; set; }

    public string? Status { get; set; }

    public decimal? Cgpa { get; set; }

    public decimal? Tsscore { get; set; }

    public string? Tsgrade { get; set; }

    public decimal? Tgp { get; set; }

    public decimal? TotalMaxMarks { get; set; }

    public decimal? Percentage { get; set; }
}
