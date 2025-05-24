using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTMonthwisestudentattendance2
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public int AttMonth { get; set; }

    public int AttYear { get; set; }

    public int WorkingDays { get; set; }

    public int PresentDays { get; set; }

    public long Academicyearid { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public int? Termid { get; set; }
}
