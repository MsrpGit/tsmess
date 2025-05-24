using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSuppliermaster1
{
    public long SupplierId { get; set; }

    public string SupplierCode { get; set; } = null!;

    public string? SupplierName { get; set; }

    public string? City { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? State { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Country { get; set; }

    public string? Pincode { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string SupplierType { get; set; } = null!;

    public long PartnerId { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<WdiMGrnmaster1> WdiMGrnmaster1s { get; set; } = new List<WdiMGrnmaster1>();
}
