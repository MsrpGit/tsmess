using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayTransaction
{
    public long Ptid { get; set; }

    public string? UserId { get; set; }

    public string Month { get; set; } = null!;

    public long HeadId { get; set; }

    public decimal? Amount { get; set; }

    public string? Installment { get; set; }

    public long AcademicYearId { get; set; }

    public string? InstallmentStartMonth { get; set; }

    public bool IsManualUpdated { get; set; }
}
