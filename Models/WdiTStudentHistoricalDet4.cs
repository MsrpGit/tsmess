using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentHistoricalDet4
{
    public string UserId { get; set; } = null!;

    public long? SchoolId { get; set; }

    public long AcademicYearId { get; set; }

    public string? PreviousInstituteDetails { get; set; }
}
