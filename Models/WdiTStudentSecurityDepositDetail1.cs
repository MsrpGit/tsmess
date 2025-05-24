using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentSecurityDepositDetail1
{
    public long Id { get; set; }

    public string DepositId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public string DepositType { get; set; } = null!;

    public string? DepositedBy { get; set; }

    public string? RefernceNo { get; set; }

    public string Status { get; set; } = null!;

    public bool IsRefundable { get; set; }

    public decimal? RefundableAmount { get; set; }

    public DateTime? RefundableDate { get; set; }

    public string? RefundedAmtGivenBy { get; set; }

    public string? RefundedAmtGivenTo { get; set; }

    public string? RefundedToAccount { get; set; }

    public long? FeeDueId { get; set; }

    public string? FeeReceiptNo { get; set; }

    public string? CollectedBy { get; set; }

    public string? Description { get; set; }

    public string? Remarks { get; set; }

    public long CollectedAcademicyearId { get; set; }

    public long PartnerId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? FeeHeadId { get; set; }

    public long ApplicationNo { get; set; }
}
