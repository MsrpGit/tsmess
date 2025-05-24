using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCategoryMaster3
{
    public long CategoryId { get; set; }

    public long PartnerId { get; set; }

    public string? CategoryName { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail3> WdiMBillingOrdersDetail3s { get; set; } = new List<WdiMBillingOrdersDetail3>();

    public virtual ICollection<WdiMGrnitem3> WdiMGrnitem3s { get; set; } = new List<WdiMGrnitem3>();

    public virtual ICollection<WdiMIndentItem3> WdiMIndentItem3s { get; set; } = new List<WdiMIndentItem3>();
}
