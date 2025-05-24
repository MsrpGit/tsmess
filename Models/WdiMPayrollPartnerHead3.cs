using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPayrollPartnerHead3
{
    public long PayRolePartnerHeadId { get; set; }

    public long HeadId { get; set; }

    public long PartnerId { get; set; }

    public bool IsFixed { get; set; }

    public decimal? Percentage { get; set; }

    public short? SlNo { get; set; }

    public bool? Status { get; set; }

    public bool IsSalaryRange { get; set; }
}
