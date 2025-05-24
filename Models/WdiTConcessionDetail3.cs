using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTConcessionDetail3
{
    public long ConcessionDetailsId { get; set; }

    public long? FeeDueId { get; set; }

    /// <summary>
    /// This is the concession amount given,This amount will be Added to &apos;ConcessionAmt&apos; col in StudentFeeDueDetails table, If the concession is &apos;Rejected&apos; then this Amount will be deducted from the &apos;ConcessionAmt&apos; col in StudentFeeDueDetails table.
    /// </summary>
    public decimal? ConcessionAmount { get; set; }

    public string? RecommendedBy { get; set; }

    public string? Reason { get; set; }

    public string? AddedBy { get; set; }

    public DateOnly? AddedOn { get; set; }

    /// <summary>
    /// Pending, Approved, Rejected
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// Action may be Approved or rejected
    /// </summary>
    public DateOnly? ActionDate { get; set; }

    public string? ActionBy { get; set; }

    public int SsconcessionId { get; set; }

    public string? RejectedReason { get; set; }
}
