using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayRollSalaryRangeTransaction1
{
    public int Id { get; set; }

    public int HeadId { get; set; }

    public int? SalaryFrom { get; set; }

    public int? SalaryTo { get; set; }

    public long PartnerId { get; set; }

    public decimal? Value { get; set; }
}
