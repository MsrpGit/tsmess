using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImItemExistingStock
{
    public long Id { get; set; }

    public string ExistingItemId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public decimal? ExistingStock { get; set; }

    public string? Units { get; set; }

    public bool Active { get; set; }

    public decimal? CostPrice { get; set; }

    public decimal? Mrpprice { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public long? CostGrnId { get; set; }

    public DateTime? MfgDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public long BatchNo { get; set; }

    public virtual ImCategoryMaster? Category { get; set; }

    public virtual ICollection<ImGrnreleasedHistory> ImGrnreleasedHistories { get; set; } = new List<ImGrnreleasedHistory>();

    public virtual ICollection<ImStoreItemStockDetail> ImStoreItemStockDetails { get; set; } = new List<ImStoreItemStockDetail>();

    public virtual ImItemmaster Item { get; set; } = null!;
}
