using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UbaSsconcessionMaster5
{
    public int SsconcessionId { get; set; }

    public string? SsconcerssionName { get; set; }

    /// <summary>
    /// MCL-Manual Count Limit; MAL-Manual Amount Limit;MPL-Manual Percentage Limit
    /// </summary>
    public string SsconcessionType { get; set; } = null!;

    public decimal SsconcessionAmountLimit { get; set; }

    public decimal SsconcessionCountLimit { get; set; }

    public decimal SsconcessionPercentageLimit { get; set; }

    /// <summary>
    /// -1: disabled; 0: Inactive; 1: Active
    /// </summary>
    public byte SsconcessionStatus { get; set; }

    public decimal TotalConsumed { get; set; }

    public long PartnerId { get; set; }

    public long Academicyearid { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public DateTime? VaildFrom { get; set; }

    public DateTime? ValidTo { get; set; }

    public int? OrderofScholorship { get; set; }

    public string? ScholorshipGroup { get; set; }

    public string? AppliedBy { get; set; }

    public string? VerifiedBy { get; set; }

    public string? AutomaticCarryToPu2 { get; set; }

    public bool? IsEarlyBird { get; set; }

    public string? ApprovedBy { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public bool IsDocumentMandatory { get; set; }
}
