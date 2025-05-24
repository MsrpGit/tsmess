using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCheckClasswiseAttendance4
{
    public int CheckSid { get; set; }

    public int? SchoolId { get; set; }

    public int? ClassId { get; set; }

    public int? SectionId { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public DateOnly? Modifieddate { get; set; }

    public string? StatusClass { get; set; }
}
