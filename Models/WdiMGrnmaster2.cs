using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMGrnmaster2
{
    public long Grnid { get; set; }

    public long? Grnno { get; set; }

    public long? BillNo { get; set; }

    public long? RefNo { get; set; }

    public long? Grrrno { get; set; }

    public long VendorId { get; set; }

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

    public virtual WdiMSuppliermaster2 Vendor { get; set; } = null!;

    public virtual ICollection<WdiMGrnitem2> WdiMGrnitem2s { get; set; } = new List<WdiMGrnitem2>();
}
