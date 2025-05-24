using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImCategoryMaster4
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

    public virtual ICollection<ImBillingOrdersDetail4> ImBillingOrdersDetail4s { get; set; } = new List<ImBillingOrdersDetail4>();

    public virtual ICollection<ImGrndetail4> ImGrndetail4s { get; set; } = new List<ImGrndetail4>();

    public virtual ICollection<ImIndentDetail4> ImIndentDetail4s { get; set; } = new List<ImIndentDetail4>();

    public virtual ICollection<ImIssueItemDetail4> ImIssueItemDetail4s { get; set; } = new List<ImIssueItemDetail4>();

    public virtual ICollection<ImItemExistingStock4> ImItemExistingStock4s { get; set; } = new List<ImItemExistingStock4>();

    public virtual ICollection<ImItemmaster4> ImItemmaster4s { get; set; } = new List<ImItemmaster4>();

    public virtual ICollection<ImKitItemDetail> ImKitItemDetails { get; set; } = new List<ImKitItemDetail>();

    public virtual ICollection<ImPurchaseOrderItem4> ImPurchaseOrderItem4s { get; set; } = new List<ImPurchaseOrderItem4>();

    public virtual ICollection<ImRepairAndMaintenanceDetail> ImRepairAndMaintenanceDetails { get; set; } = new List<ImRepairAndMaintenanceDetail>();
}
