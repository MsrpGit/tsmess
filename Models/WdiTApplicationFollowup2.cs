using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTApplicationFollowup2
{
    public long FollowupId { get; set; }

    public int? ApplicationNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? FollowupType { get; set; }

    public string? FollowupDetails { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
