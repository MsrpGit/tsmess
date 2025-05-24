using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTFinalExamWeightage4
{
    public long Id { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public long ClassId { get; set; }

    public string ExamId { get; set; } = null!;

    public double Percentage { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? TermId { get; set; }

    public string? ExamName { get; set; }
}
