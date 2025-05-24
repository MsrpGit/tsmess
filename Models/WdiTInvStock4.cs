using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInvStock4
{
    public long StockId { get; set; }

    public long CategoryId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Units { get; set; }

    public long? Qty { get; set; }

    public long AcademicYearId { get; set; }
}
