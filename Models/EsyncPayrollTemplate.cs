using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncPayrollTemplate
{
    public long ProllTemplateId { get; set; }

    public string ProllTemplateName { get; set; } = null!;

    public byte ImplementationMonth { get; set; }

    public short ImplementationYear { get; set; }

    public long PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
