using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTOnboardAndExcessPayment
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public long? ApplicationNo { get; set; }

    public decimal Amount { get; set; }

    public DateTime DateOfPayment { get; set; }

    public string? Status { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Remarks { get; set; }

    public string? PaidBy { get; set; }

    public bool? MappedStatus { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public string Type { get; set; } = null!;
}
