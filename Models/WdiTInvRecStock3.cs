using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInvRecStock3
{
    public long RecStockId { get; set; }

    public string BillNo { get; set; } = null!;

    public DateTime BillDate { get; set; }

    public long? SupplierId { get; set; }

    public long? CategoryId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Units { get; set; }

    public decimal Qty { get; set; }

    public decimal? Unitrate { get; set; }

    public decimal? Amount { get; set; }

    public decimal? TotalRcptAmount { get; set; }

    public bool? Active { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
