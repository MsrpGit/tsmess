using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInvIssuedStock4
{
    public long IssueStockId { get; set; }

    public string BillNo { get; set; } = null!;

    public long CategoryId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public long Quantity { get; set; }

    public string? Units { get; set; }

    public bool? Active { get; set; }

    public byte UserType { get; set; }

    /// <summary>
    /// Store partner (sub branch) details  which stock is issued
    /// </summary>
    public long IssuedPartnerId { get; set; }

    public long PartnerId { get; set; }

    public DateTime StockIssueDate { get; set; }

    public long AcademicYearId { get; set; }
}
