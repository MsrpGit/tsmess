using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTFeeDueMonth1
{
    public int FeeHeadMonthsId { get; set; }

    public long FeeHeadId { get; set; }

    public int ClassId { get; set; }

    public string FeeDueMonth { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string Sections { get; set; } = null!;
}
