using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTenanttemplatetypegroup
{
    public long Id { get; set; }

    public string TemplateTypeGroup { get; set; } = null!;

    public string TemplateTypeDesc { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
