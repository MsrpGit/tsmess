using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwFeeDetail4
{
    public long? PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string UserId { get; set; } = null!;

    public string? AdmissionNo { get; set; }

    public string? Name { get; set; }

    public string RollNo { get; set; } = null!;

    public string? Class { get; set; }

    public string? Section { get; set; }

    public decimal? AprovedConcAmt { get; set; }

    public decimal HeadAmount { get; set; }

    public DateTime? LastPaidDate { get; set; }

    public string? Status { get; set; }

    public decimal Amount { get; set; }

    public string? DateOfPayment { get; set; }

    public string? PaidBy { get; set; }

    public DateTime? Duedate { get; set; }

    public decimal? AmountPaid { get; set; }

    public long? PaymentId { get; set; }

    public string? FeeFor { get; set; }

    public string? ReceiptNo { get; set; }

    public string ModeOfPayment { get; set; } = null!;

    public decimal? DueAmount { get; set; }

    public long? FeeDueId { get; set; }

    public long? HeadId { get; set; }

    public string? HeadName { get; set; }

    public decimal? FineAmount { get; set; }

    public int? ClassId { get; set; }

    public string? FriendlyName { get; set; }
}
