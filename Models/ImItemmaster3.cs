using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImItemmaster3
{
    public long Id { get; set; }

    public string ItemId { get; set; } = null!;

    public string ItemName { get; set; } = null!;

    public string ItemType { get; set; } = null!;

    public bool Active { get; set; }

    public string? ItemCode { get; set; }

    public string? CategoryId { get; set; }

    public string? Ledger { get; set; }

    public bool AssetItem { get; set; }

    public bool ItemForProduction { get; set; }

    public bool BatchWiseItem { get; set; }

    public string? Measurement { get; set; }

    public string? Units { get; set; }

    public string? ReOrderQty { get; set; }

    public string? MinOrderQty { get; set; }

    public long DepartmentId { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ImCategoryMaster3? Category { get; set; }

    public virtual ICollection<ImBillingOrdersDetail3> ImBillingOrdersDetail3s { get; set; } = new List<ImBillingOrdersDetail3>();

    public virtual ICollection<ImGrndetail3> ImGrndetail3s { get; set; } = new List<ImGrndetail3>();

    public virtual ICollection<ImIndentDetail3> ImIndentDetail3s { get; set; } = new List<ImIndentDetail3>();

    public virtual ICollection<ImIssueItemDetail3> ImIssueItemDetail3s { get; set; } = new List<ImIssueItemDetail3>();

    public virtual ICollection<ImItemExistingStock3> ImItemExistingStock3s { get; set; } = new List<ImItemExistingStock3>();

    public virtual ICollection<ImItemsReceivedStock3> ImItemsReceivedStock3s { get; set; } = new List<ImItemsReceivedStock3>();

    public virtual ICollection<ImPurchaseOrderItem3> ImPurchaseOrderItem3s { get; set; } = new List<ImPurchaseOrderItem3>();
}
