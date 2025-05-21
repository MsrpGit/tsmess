using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImCategoryMaster
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

    public virtual ICollection<ImBillingOrdersDetail> ImBillingOrdersDetails { get; set; } = new List<ImBillingOrdersDetail>();

    public virtual ICollection<ImGrndetail> ImGrndetails { get; set; } = new List<ImGrndetail>();

    public virtual ICollection<ImIndentDetail> ImIndentDetails { get; set; } = new List<ImIndentDetail>();

    public virtual ICollection<ImIssueItemDetail> ImIssueItemDetails { get; set; } = new List<ImIssueItemDetail>();

    public virtual ICollection<ImItemExistingStock> ImItemExistingStocks { get; set; } = new List<ImItemExistingStock>();

    public virtual ICollection<ImItemmaster> ImItemmasters { get; set; } = new List<ImItemmaster>();

    public virtual ICollection<ImKitItemDetail> ImKitItemDetails { get; set; } = new List<ImKitItemDetail>();

    public virtual ICollection<ImPurchaseOrderItem> ImPurchaseOrderItems { get; set; } = new List<ImPurchaseOrderItem>();

    public virtual ICollection<ImRepairAndMaintenanceDetail> ImRepairAndMaintenanceDetails { get; set; } = new List<ImRepairAndMaintenanceDetail>();
}
