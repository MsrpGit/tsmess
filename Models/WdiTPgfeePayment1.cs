using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPgfeePayment1
{
    public long PaymentId { get; set; }

    public string? ReceiptNo { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public decimal? Amount { get; set; }

    public string? PaidBy { get; set; }

    public string? ModeOfPayment { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public bool? RecStatus { get; set; }

    public DateTime? DateOfDelete { get; set; }

    public long AcademicYearId { get; set; }

    public string? AccountNo { get; set; }

    public int? PgstatusId { get; set; }

    public decimal? Transcharges { get; set; }

    public int Acknowledge { get; set; }

    public string? AckReceiptNo { get; set; }

    public string? MerchantTransId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public long CollectedBranchId { get; set; }

    public string? CollectedBranchUser { get; set; }

    public string? CollectedBranchname { get; set; }

    public byte PgfeeProcessStatus { get; set; }

    public string ActualReceiptNoGenerated { get; set; } = null!;
}
