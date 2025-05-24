using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPartnerTemplatesNew5
{
    public long PartnerTemplateId { get; set; }

    public int TemplateId { get; set; }

    public string TemplateName { get; set; } = null!;

    public string EmailTemplateText { get; set; } = null!;

    public string? SmstemplateText { get; set; }

    public string? TemplateColumns { get; set; }

    public string? RelatedTo { get; set; }

    public byte? MessageType { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime UpdatedOn { get; set; }

    public string UpdatedBy { get; set; } = null!;
}
