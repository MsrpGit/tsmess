using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EdusyncMiscFeeTracker
{
    public long EdsyncMftid { get; set; }

    public string? Rollno { get; set; }

    public string? StudentName { get; set; }

    public string? Programme { get; set; }

    public string? Branch { get; set; }

    public string? Batch { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public int? NoofFeeItems { get; set; }

    public string? FeeItemDetails { get; set; }

    public decimal? FeeAmount { get; set; }

    public decimal? ConcessionAmount { get; set; }

    public string? ConcessionDetails { get; set; }

    public string? FeePaymentStatus { get; set; }

    public DateTime AppAmountPaidDate { get; set; }

    public string PaymentMode { get; set; } = null!;

    public int? FeePgStatusId { get; set; }

    public string? PgTransactionId { get; set; }

    public string? PaymentReferenceNo { get; set; }

    public string? MiscFeeReceiptNo { get; set; }

    public decimal? TransAmount { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
