using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImBillingOrdersDetail1
{
    public long Id { get; set; }

    public string BillTranId { get; set; } = null!;

    public string BillId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

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

    public virtual ImBillingOrder1 Bill { get; set; } = null!;

    public virtual ImCategoryMaster1 Category { get; set; } = null!;

    public virtual ImItemmaster1 Item { get; set; } = null!;
}
