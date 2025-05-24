using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class TempOne
{
    public int Sid { get; set; }

    public string? Sname { get; set; }

    public int? Rollno { get; set; }

    public string? Course { get; set; }

    public virtual ICollection<TempOrder> TempOrders { get; set; } = new List<TempOrder>();
}
