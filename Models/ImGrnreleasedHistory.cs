using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImGrnreleasedHistory
{
    public long Id { get; set; }

    public string TrackId { get; set; } = null!;

    public DateTime ReleaseDate { get; set; }

    public string StoreId { get; set; } = null!;

    public string Grnid { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public decimal? ReleasedStock { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? Mrpprice { get; set; }

    public string? Units { get; set; }

    public bool Active { get; set; }

    public long DepartmentId { get; set; }

    public DateTime? MfgDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public long BatchNo { get; set; }

    public string ExistingStockItemId { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ImItemExistingStock ExistingStockItem { get; set; } = null!;

    public virtual ImGrnmaster Grn { get; set; } = null!;

    public virtual ImStoreDetail Store { get; set; } = null!;
}
