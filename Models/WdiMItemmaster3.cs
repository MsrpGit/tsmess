using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemmaster3
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

    public virtual ICollection<WdiMBillingOrdersDetail3> WdiMBillingOrdersDetail3s { get; set; } = new List<WdiMBillingOrdersDetail3>();

    public virtual ICollection<WdiMGrnitem3> WdiMGrnitem3s { get; set; } = new List<WdiMGrnitem3>();

    public virtual ICollection<WdiMIndentItem3> WdiMIndentItem3s { get; set; } = new List<WdiMIndentItem3>();
}
