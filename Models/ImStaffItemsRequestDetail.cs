using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImStaffItemsRequestDetail
{
    public long Id { get; set; }

    public string RequestTranId { get; set; } = null!;

    public string RequestId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public decimal? ExistingStock { get; set; }

    public decimal? Price { get; set; }

    public decimal? Quantity { get; set; }

    public string? Units { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string StoreStockItemId { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }
}
