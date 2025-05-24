using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImGrnmaster3
{
    public long Id { get; set; }

    public string Grnid { get; set; } = null!;

    public string? PurchaseOrderId { get; set; }

    public string? Grnno { get; set; }

    public string? BillNo { get; set; }

    public string? RefNo { get; set; }

    public string? Grrrno { get; set; }

    public string VendorId { get; set; } = null!;

    public DateTime? Grndate { get; set; }

    public DateTime? BillDate { get; set; }

    public DateTime? RefDate { get; set; }

    public DateTime? Grrrdate { get; set; }

    public long DepartmentId { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImGrndetail3> ImGrndetail3s { get; set; } = new List<ImGrndetail3>();

    public virtual ICollection<ImItemsReceivedStock3> ImItemsReceivedStock3s { get; set; } = new List<ImItemsReceivedStock3>();

    public virtual ImSupplierMaster3 Vendor { get; set; } = null!;
}
