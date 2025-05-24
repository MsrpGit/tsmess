using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTAbsent1
{
    public int AbsentId { get; set; }

    public long? SchoolId { get; set; }

    public string? UserId { get; set; }

    public DateTime? DateOfAbsent { get; set; }

    public long AcademicYearId { get; set; }

    public string? Reason { get; set; }
}
