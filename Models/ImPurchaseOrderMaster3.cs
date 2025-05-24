using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImPurchaseOrderMaster3
{
    public long Id { get; set; }

    public string PurchaseOrderId { get; set; } = null!;

    public string IndentId { get; set; } = null!;

    public DateTime PurchaseOrderDate { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long DepartmentId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImItemsReceivedStock3> ImItemsReceivedStock3s { get; set; } = new List<ImItemsReceivedStock3>();

    public virtual ICollection<ImPurchaseOrderItem3> ImPurchaseOrderItem3s { get; set; } = new List<ImPurchaseOrderItem3>();
}
