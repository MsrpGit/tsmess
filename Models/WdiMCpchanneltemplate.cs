using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCpchanneltemplate
{
    public int Id { get; set; }

    public string CptemplateUniqueId { get; set; } = null!;

    public string TemplateFriendlyName { get; set; } = null!;

    public string? Cptexttemplateformat { get; set; }

    public string? Cpmailtemplateformat { get; set; }

    public string? Cpnotificationtemplateformat { get; set; }

    public string TemplateTypeGroup { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
