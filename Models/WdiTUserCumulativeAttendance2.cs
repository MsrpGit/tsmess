using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTUserCumulativeAttendance2
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string NameOfUnit { get; set; } = null!;

    public int WorkingDays { get; set; }

    public decimal AbsentDays { get; set; }

    public decimal PresentDays { get; set; }

    public decimal Percentage { get; set; }

    public string TypeOfUnit { get; set; } = null!;

    public long AcdemicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
