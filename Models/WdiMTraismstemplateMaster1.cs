using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTraismstemplateMaster1
{
    public int Id { get; set; }

    public string TraiTemplateid { get; set; } = null!;

    public string TemplateFormat { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public string? TemplateFriendlyName { get; set; }
}
