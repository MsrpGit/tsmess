using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImRepairAndMaintenanceMaster
{
    public long Id { get; set; }

    public string RepairId { get; set; } = null!;

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

    public string? ServiceCharge { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImRepairAndMaintenanceDetail> ImRepairAndMaintenanceDetails { get; set; } = new List<ImRepairAndMaintenanceDetail>();

    public virtual ImSupplierMaster Vendor { get; set; } = null!;
}
