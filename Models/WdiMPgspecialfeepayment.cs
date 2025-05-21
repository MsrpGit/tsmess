using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPgspecialfeepayment
{
    public long SpecialFeeReceiptId { get; set; }

    public string ReceiptNo { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public decimal Amount { get; set; }

    public bool? RecStatus { get; set; }

    public string? Status { get; set; }

    public DateOnly? DateofDelete { get; set; }

    public string? PaymentRemarks { get; set; }

    public long? PgstatusId { get; set; }

    public string? MerchantTransId { get; set; }

    public byte? PgfeeProcessStatus { get; set; }

    public string? ActualReceiptNoGenerated { get; set; }

    public string? Remarks { get; set; }

    public long AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
