using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class FormTemplate
{
    public int TemplateId { get; set; }

    public int? UserId { get; set; }

    public string? TemplateName { get; set; }

    public string? TemplateContent { get; set; }
}
