using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImIssueItemDetail2
{
    public long Id { get; set; }

    public string IssueTranId { get; set; } = null!;

    public string IssueId { get; set; } = null!;

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

    public virtual ImCategoryMaster2 Category { get; set; } = null!;

    public virtual ImIssueMaster2 Issue { get; set; } = null!;

    public virtual ImItemmaster2 Item { get; set; } = null!;
}
