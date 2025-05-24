using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTRefundDetail5
{
    public long RefundId { get; set; }

    public string ReceiptNo { get; set; } = null!;

    public long FeeHeadId { get; set; }

    public long? FeeDueId { get; set; }

    public decimal RefundAmount { get; set; }

    public string ModeOfRefund { get; set; } = null!;

    public long? AccNumber { get; set; }

    public string? Remarks { get; set; }

    public string RefundedBy { get; set; } = null!;

    public DateTime RefundedOn { get; set; }
}
