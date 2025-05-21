using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEmailtemplateMaster
{
    public int Id { get; set; }

    public string Templateid { get; set; } = null!;

    public string TemplateFormat { get; set; } = null!;

    public long? Partnerid { get; set; }

    public string? TemplateFriendlyName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
