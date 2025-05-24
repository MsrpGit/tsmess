using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPayrollMasterhead5
{
    public long HeadId { get; set; }

    public string? HeadName { get; set; }

    public string? HeadType { get; set; }

    /// <summary>
    /// R - Regular, L - Loan , A - Advance. Default is &apos;R&apos;.
    /// </summary>
    public string DeductionType { get; set; } = null!;
}
