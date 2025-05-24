using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCategoryMaster2
{
    public long CategoryId { get; set; }

    public long PartnerId { get; set; }

    public string? CategoryName { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail2> WdiMBillingOrdersDetail2s { get; set; } = new List<WdiMBillingOrdersDetail2>();

    public virtual ICollection<WdiMGrnitem2> WdiMGrnitem2s { get; set; } = new List<WdiMGrnitem2>();

    public virtual ICollection<WdiMIndentItem2> WdiMIndentItem2s { get; set; } = new List<WdiMIndentItem2>();
}
