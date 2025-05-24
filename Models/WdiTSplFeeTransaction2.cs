using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSplFeeTransaction2
{
    public int TransactionId { get; set; }

    public int FeeId { get; set; }

    public string UserId { get; set; } = null!;

    public decimal Discount { get; set; }

    public decimal Amount { get; set; }

    public long AcademicYearId { get; set; }

    public long PartnerId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string? Receipt { get; set; }

    public bool? RecStatus { get; set; }

    public long? Quantity { get; set; }

    public string? ModeOfPayment { get; set; }
}
