using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImItemmaster1
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

    public virtual ImCategoryMaster1? Category { get; set; }

    public virtual ICollection<ImBillingOrdersDetail1> ImBillingOrdersDetail1s { get; set; } = new List<ImBillingOrdersDetail1>();

    public virtual ICollection<ImGrndetail1> ImGrndetail1s { get; set; } = new List<ImGrndetail1>();

    public virtual ICollection<ImIndentDetail1> ImIndentDetail1s { get; set; } = new List<ImIndentDetail1>();

    public virtual ICollection<ImIssueItemDetail1> ImIssueItemDetail1s { get; set; } = new List<ImIssueItemDetail1>();

    public virtual ICollection<ImItemExistingStock1> ImItemExistingStock1s { get; set; } = new List<ImItemExistingStock1>();

    public virtual ICollection<ImItemsReceivedStock1> ImItemsReceivedStock1s { get; set; } = new List<ImItemsReceivedStock1>();

    public virtual ICollection<ImPurchaseOrderItem1> ImPurchaseOrderItem1s { get; set; } = new List<ImPurchaseOrderItem1>();
}
