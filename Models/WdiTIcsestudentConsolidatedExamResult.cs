using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsestudentConsolidatedExamResult
{
    public long Id { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public long? ClassId { get; set; }

    public long? SectionId { get; set; }

    public string? UserId { get; set; }

    public long? ExamTemplateId { get; set; }

    public decimal? TotalMaxMarks { get; set; }

    public decimal? TotalSecMarks { get; set; }

    public string? Grade { get; set; }

    public int? ClassRank { get; set; }

    public int? StreamRank { get; set; }

    public decimal? Percentage { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
