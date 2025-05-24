using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImItemsReceivedStock3
{
    public long Id { get; set; }

    public string ItemsReceivedStockId { get; set; } = null!;

    public string Grnid { get; set; } = null!;

    public string PurchaseOrderId { get; set; } = null!;

    public string ItemId { get; set; } = null!;

    public long? RequestedStock { get; set; }

    public long? ReceivedStock { get; set; }

    public long? ReceivedLessStock { get; set; }

    public long? ReceivedMoreStock { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public bool Active { get; set; }

    public virtual ImGrnmaster3 Grn { get; set; } = null!;

    public virtual ImItemmaster3 Item { get; set; } = null!;

    public virtual ImPurchaseOrderMaster3 PurchaseOrder { get; set; } = null!;
}
