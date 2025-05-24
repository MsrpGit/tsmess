using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMFinancialYear4
{
    public long FinancialYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long AcademicYearId { get; set; }

    public bool Iscurrent { get; set; }

    public long PartnerId { get; set; }
}
