using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTReportTemplate3
{
    public int ReportTemplateId { get; set; }

    public string ReportTemplateName { get; set; } = null!;

    public string XsltemplateText { get; set; } = null!;

    public string? RelatedTo { get; set; }

    public bool IsActive { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedOn { get; set; }
}
