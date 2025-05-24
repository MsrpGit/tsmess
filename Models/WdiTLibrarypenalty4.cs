using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLibrarypenalty4
{
    public long PenaltyId { get; set; }

    public long LirId { get; set; }

    public decimal Amount { get; set; }

    public DateTime? PaidDate { get; set; }

    public int? NoOfDays { get; set; }

    public int? MaxDays { get; set; }

    /// <summary>
    /// WHEN 0 THEN &apos;PAID&apos; ELSE &apos;PENDING&apos;
    /// </summary>
    public string? Active { get; set; }

    public string? Remarks { get; set; }

    public decimal Concession { get; set; }
}
