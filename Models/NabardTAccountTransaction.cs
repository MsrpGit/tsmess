using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class NabardTAccountTransaction
{
    public int TransId { get; set; }

    public string VoucherNo { get; set; } = null!;

    public DateTime? VoucherDate { get; set; }

    public string? TranRefNo { get; set; }

    /// <summary>
    /// Payment,Receipt,Contra,Sales,Purchase
    /// </summary>
    public string? VoucherType { get; set; }

    public string? TransType { get; set; }

    public int DrAcHeadId { get; set; }

    public decimal? DrAmount { get; set; }

    public decimal? DrClosingBalance { get; set; }

    public int? CrAcHeadId { get; set; }

    public decimal? CrAmount { get; set; }

    public decimal? CrClosingBalance { get; set; }

    public string Narration { get; set; } = null!;

    public long FinancialYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public decimal? Freight { get; set; }

    public decimal? Labour { get; set; }

    public decimal? Discount { get; set; }
}
