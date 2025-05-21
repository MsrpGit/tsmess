using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTLeaveTransactionDetail
{
    public long? LeaveId { get; set; }

    public string? LeaveDate { get; set; }

    public long? AcademicYearId { get; set; }
}
