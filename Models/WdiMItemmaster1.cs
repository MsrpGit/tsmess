using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemmaster1
{
    public long ItemId { get; set; }

    public string ItemName { get; set; } = null!;

    /// <summary>
    /// this table is serves common item master for unicampus. eventhough it was names as libraryitemmaster we are using it for all
    /// </summary>
    public string ItemType { get; set; } = null!;

    public long PartnerId { get; set; }

    public bool Active { get; set; }

    public string? ItemCode { get; set; }

    public long? CategoryId { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail1> WdiMBillingOrdersDetail1s { get; set; } = new List<WdiMBillingOrdersDetail1>();

    public virtual ICollection<WdiMGrnitem1> WdiMGrnitem1s { get; set; } = new List<WdiMGrnitem1>();

    public virtual ICollection<WdiMIndentItem1> WdiMIndentItem1s { get; set; } = new List<WdiMIndentItem1>();
}
