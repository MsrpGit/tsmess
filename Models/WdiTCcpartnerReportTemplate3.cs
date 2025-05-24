using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCcpartnerReportTemplate3
{
    public long CcpartnerReportTemplateId { get; set; }

    public long CcreportTemplateId { get; set; }

    public long PartnerId { get; set; }

    public string XsltemplateText { get; set; } = null!;

    public string RelatedTo { get; set; } = null!;

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsModified { get; set; }

    public string? Defaultxml { get; set; }
}
