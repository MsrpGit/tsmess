using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCceexamsMapping4
{
    public int MappedExamId { get; set; }

    public string? ExamName { get; set; }

    public string? MappedExams { get; set; }

    public int? ExamsPercentage { get; set; }

    public int? ToolsPercentage { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
