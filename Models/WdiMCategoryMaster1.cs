using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMCategoryMaster1
{
    public long CategoryId { get; set; }

    public long PartnerId { get; set; }

    public string? CategoryName { get; set; }

    public string CategoryCode { get; set; } = null!;

    public string CategoryType { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail1> WdiMBillingOrdersDetail1s { get; set; } = new List<WdiMBillingOrdersDetail1>();

    public virtual ICollection<WdiMGrnitem1> WdiMGrnitem1s { get; set; } = new List<WdiMGrnitem1>();

    public virtual ICollection<WdiMIndentItem1> WdiMIndentItem1s { get; set; } = new List<WdiMIndentItem1>();
}
