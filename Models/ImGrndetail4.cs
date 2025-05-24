using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImGrndetail4
{
    public long Id { get; set; }

    public string GrnitemId { get; set; } = null!;

    public string Grnid { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string CategoryId { get; set; } = null!;

    public string? ItemBrandName { get; set; }

    public decimal? ExistingStock { get; set; }

    public decimal? ReceivedStock { get; set; }

    public string? Units { get; set; }

    public DateTime? RequestedDate { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? Mrpprice { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? MfgDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Surcharge { get; set; }

    public decimal? Discount { get; set; }

    public decimal? AdditionalExp { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public decimal? VatTaxNo { get; set; }

    public virtual ImCategoryMaster4 Category { get; set; } = null!;

    public virtual ImGrnmaster4 Grn { get; set; } = null!;

    public virtual ImItemmaster4 Item { get; set; } = null!;
}
