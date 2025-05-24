using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcseexamsMapping1
{
    public int MappedExamId { get; set; }

    public int? ClassId { get; set; }

    public string? ExamName { get; set; }

    public int? MappedExam { get; set; }

    public string? AssesmentType { get; set; }

    public int? ExamsPercentage { get; set; }

    public int? ToolsPercentage { get; set; }

    public int? ClassCategory { get; set; }

    public int? TermId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
