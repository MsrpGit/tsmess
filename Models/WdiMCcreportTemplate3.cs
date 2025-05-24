using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCcreportTemplate3
{
    public long CcreportTemplateId { get; set; }

    public string CcreportTemplateName { get; set; } = null!;

    public string XsltemplateText { get; set; } = null!;

    public string? RelatedTo { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
