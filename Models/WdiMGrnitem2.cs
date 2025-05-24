using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMGrnitem2
{
    public long GrnitemId { get; set; }

    public long Grnid { get; set; }

    public long ItemId { get; set; }

    public long CategoryId { get; set; }

    public string? ItemBrandName { get; set; }

    public long? ExistingStock { get; set; }

    public long? ReceivedStock { get; set; }

    public string? Units { get; set; }

    public DateTime? RequestedDate { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? Mrpprice { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? MfgDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? VatTaxNo { get; set; }

    public string? Surcharge { get; set; }

    public decimal? Discount { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual WdiMCategoryMaster2 Category { get; set; } = null!;

    public virtual WdiMGrnmaster2 Grn { get; set; } = null!;

    public virtual WdiMItemmaster2 Item { get; set; } = null!;
}
