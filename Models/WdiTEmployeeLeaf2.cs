using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTEmployeeLeaf2
{
    public long EmpLeaveId { get; set; }

    public string? UserId { get; set; }

    public string? Month { get; set; }

    public decimal? Leaves { get; set; }

    public long AcademicYearId { get; set; }
}
