using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ImSupplierMaster2
{
    public long Id { get; set; }

    public string SupplierId { get; set; } = null!;

    public string SupplierName { get; set; } = null!;

    public string? ContactPerson { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Pincode { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? FaxNo { get; set; }

    public string? Url { get; set; }

    public string? Ledger { get; set; }

    public bool Active { get; set; }

    public string? Remarks { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public virtual ICollection<ImGrnmaster2> ImGrnmaster2s { get; set; } = new List<ImGrnmaster2>();
}
