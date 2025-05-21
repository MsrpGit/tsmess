using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncStudentFeeDueTaxdetail
{
    public long Id { get; set; }

    public long? PaymentDetailsId { get; set; }

    public long? FeeDueId { get; set; }

    public long? TaxId { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? TaxAmount { get; set; }

    public decimal? RemainingAmount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? TaxReceiptNo { get; set; }

    public bool SyncStatus { get; set; }

    public bool IsPrevsPresentFuture { get; set; }
}
