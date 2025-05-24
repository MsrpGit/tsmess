using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImCategoryMaster3
{
    public long Id { get; set; }

    public string CategoryId { get; set; } = null!;

    public string? CategoryName { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryType { get; set; }

    public bool Active { get; set; }

    public long ParentCategory { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public long DepartmentId { get; set; }

    public virtual ICollection<ImBillingOrdersDetail3> ImBillingOrdersDetail3s { get; set; } = new List<ImBillingOrdersDetail3>();

    public virtual ICollection<ImGrndetail3> ImGrndetail3s { get; set; } = new List<ImGrndetail3>();

    public virtual ICollection<ImIndentDetail3> ImIndentDetail3s { get; set; } = new List<ImIndentDetail3>();

    public virtual ICollection<ImIssueItemDetail3> ImIssueItemDetail3s { get; set; } = new List<ImIssueItemDetail3>();

    public virtual ICollection<ImItemExistingStock3> ImItemExistingStock3s { get; set; } = new List<ImItemExistingStock3>();

    public virtual ICollection<ImItemmaster3> ImItemmaster3s { get; set; } = new List<ImItemmaster3>();

    public virtual ICollection<ImPurchaseOrderItem3> ImPurchaseOrderItem3s { get; set; } = new List<ImPurchaseOrderItem3>();
}
