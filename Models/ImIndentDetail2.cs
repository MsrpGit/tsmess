using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImIndentDetail2
{
    public long Id { get; set; }

    public string IndentItemId { get; set; } = null!;

    public string IndentId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public string? CategoryId { get; set; }

    public string? ItemBrandName { get; set; }

    public long? ExistingStock { get; set; }

    public long? RequestedStock { get; set; }

    public string? Units { get; set; }

    public decimal? ExpCost { get; set; }

    public DateTime? RequestedDate { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ImCategoryMaster2? Category { get; set; }

    public virtual ImIndentMaster2 Indent { get; set; } = null!;

    public virtual ImItemmaster2 Item { get; set; } = null!;
}
