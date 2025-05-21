using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBankTransaction
{
    public long Sno { get; set; }

    public long? AccNumber { get; set; }

    public DateTime? DateOfTrans { get; set; }

    public string? TransType { get; set; }

    public decimal? Amount { get; set; }

    public string? RefDetails { get; set; }

    public string? TransSource { get; set; }

    public long AcademicYearId { get; set; }
}
