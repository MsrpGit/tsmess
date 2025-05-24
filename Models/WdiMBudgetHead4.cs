using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBudgetHead4
{
    public long TargetId { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public decimal Target { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
