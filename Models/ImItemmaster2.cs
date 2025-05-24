using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImItemmaster2
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

    public virtual ImCategoryMaster2? Category { get; set; }

    public virtual ICollection<ImBillingOrdersDetail2> ImBillingOrdersDetail2s { get; set; } = new List<ImBillingOrdersDetail2>();

    public virtual ICollection<ImGrndetail2> ImGrndetail2s { get; set; } = new List<ImGrndetail2>();

    public virtual ICollection<ImIndentDetail2> ImIndentDetail2s { get; set; } = new List<ImIndentDetail2>();

    public virtual ICollection<ImIssueItemDetail2> ImIssueItemDetail2s { get; set; } = new List<ImIssueItemDetail2>();

    public virtual ICollection<ImItemExistingStock2> ImItemExistingStock2s { get; set; } = new List<ImItemExistingStock2>();

    public virtual ICollection<ImItemsReceivedStock2> ImItemsReceivedStock2s { get; set; } = new List<ImItemsReceivedStock2>();

    public virtual ICollection<ImPurchaseOrderItem2> ImPurchaseOrderItem2s { get; set; } = new List<ImPurchaseOrderItem2>();
}
