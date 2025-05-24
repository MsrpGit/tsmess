using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class CsaMPerformance4
{
    public long PerformanceId { get; set; }

    public decimal PassPercent { get; set; }

    public string ClassName { get; set; } = null!;

    public string ExamName { get; set; } = null!;

    public string PartnerName { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime ProcessedDate { get; set; }
}
