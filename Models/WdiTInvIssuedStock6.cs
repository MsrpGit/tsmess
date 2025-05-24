using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInvIssuedStock6
{
    public long IssueStockId { get; set; }

    public string BillNo { get; set; } = null!;

    public long CategoryId { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public decimal Quantity { get; set; }

    public string? Units { get; set; }

    public bool? Active { get; set; }

    public byte UserType { get; set; }

    public string UserId { get; set; } = null!;

    public long PartnerId { get; set; }

    public DateTime StockIssueDate { get; set; }

    public long AcademicYearId { get; set; }

    public string? Remarks { get; set; }

    public string? ReceiptNo { get; set; }

    public decimal? Value { get; set; }

    public string? DeliveryNumber { get; set; }

    public string? DemandNote { get; set; }

    public string? IssuedBy { get; set; }
}
