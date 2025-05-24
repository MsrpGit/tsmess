using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTDashboardView4
{
    public long Id { get; set; }

    public string DataViewName { get; set; } = null!;

    public string DataViewText { get; set; } = null!;

    public DateTime LastSyncDate { get; set; }

    public long Academicyearid { get; set; }
}
