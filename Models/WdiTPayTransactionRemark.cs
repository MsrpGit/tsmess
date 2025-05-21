using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPayTransactionRemark
{
    public long RemarksId { get; set; }

    public string? Remarks { get; set; }

    public string? UserId { get; set; }

    public string? Month { get; set; }

    public long? AcademicYearId { get; set; }
}
