using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemmaster
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

    public long Academicyearid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public long AcHeadId { get; set; }

    public virtual ICollection<WdiMBillingOrdersDetail> WdiMBillingOrdersDetails { get; set; } = new List<WdiMBillingOrdersDetail>();
}
