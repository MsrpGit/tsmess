using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcLmMLeavesProcessingDetail3
{
    public long CalculatedLeavesId { get; set; }

    public string? UserId { get; set; }

    public bool MonthlyLeavesCalculated { get; set; }

    public bool YearlyLeavesCalculated { get; set; }

    public string? Remarks { get; set; }

    public string? LeavesCalculatedForMonth { get; set; }

    public string? LeavesCalculatedForYear { get; set; }

    public bool Active { get; set; }

    public long? PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
