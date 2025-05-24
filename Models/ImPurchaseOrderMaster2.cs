using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImPurchaseOrderMaster2
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

    public virtual ICollection<ImItemsReceivedStock2> ImItemsReceivedStock2s { get; set; } = new List<ImItemsReceivedStock2>();

    public virtual ICollection<ImPurchaseOrderItem2> ImPurchaseOrderItem2s { get; set; } = new List<ImPurchaseOrderItem2>();
}
