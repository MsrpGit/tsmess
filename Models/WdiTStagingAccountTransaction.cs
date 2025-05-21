using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStagingAccountTransaction
{
    public int TransId { get; set; }

    public string VoucherNo { get; set; } = null!;

    public DateTime? VoucherDate { get; set; }

    public string? TranRefNo { get; set; }

    /// <summary>
    /// Payment,Receipt,Contra,Sales,Purchase
    /// </summary>
    public string? VoucherType { get; set; }

    public int DrAcHeadId { get; set; }

    public decimal? DrAmount { get; set; }

    public decimal? DrClosingBalance { get; set; }

    public int? CrAcHeadId { get; set; }

    public decimal? CrAmount { get; set; }

    public decimal? CrClosingBalance { get; set; }

    /// <summary>
    /// 0 means Pending..1 means Approved..-1 means Rejected
    /// </summary>
    public byte Status { get; set; }

    public string Narration { get; set; } = null!;

    public decimal? Freight { get; set; }

    public decimal? Labour { get; set; }

    public decimal? Discount { get; set; }

    public DateOnly? Chequecleareddate { get; set; }

    public long M2mtransId { get; set; }

    public long PartnerId { get; set; }

    public long OrganizationId { get; set; }

    public long UcbfinancialYearId { get; set; }

    public bool SyncStatus { get; set; }

    public long AcademicYearId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
