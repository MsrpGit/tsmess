using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPartnerBusinessRule2
{
    public long PartnerBruleId { get; set; }

    public long BusinessRuleId { get; set; }

    public string ValueFrom { get; set; } = null!;

    public string? ValueTo { get; set; }

    public long PartnerId { get; set; }
}
