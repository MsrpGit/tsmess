using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMtnfeePayRequest3
{
    public long MtnfeePayRequestId { get; set; }

    public string? ReceiptNo { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public decimal? Amount { get; set; }

    public string? PaidBy { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string? AdminNo { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public string? Acno { get; set; }

    public string? MomTransactionId { get; set; }

    public long? PptokenId { get; set; }
}
