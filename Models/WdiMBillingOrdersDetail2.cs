using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBillingOrdersDetail2
{
    public long BillTranId { get; set; }

    public long BillId { get; set; }

    public long ItemId { get; set; }

    public long CategoryId { get; set; }

    public long? ExistingStock { get; set; }

    public decimal? Price { get; set; }

    public long? Quantity { get; set; }

    public string? Units { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual WdiMBillingOrder2 Bill { get; set; } = null!;

    public virtual WdiMCategoryMaster2 Category { get; set; } = null!;

    public virtual WdiMItemmaster2 Item { get; set; } = null!;
}
