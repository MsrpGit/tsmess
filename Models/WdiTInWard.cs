using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTInWard
{
    public int InWardId { get; set; }

    public long VisitorId { get; set; }

    public string? InwardNumber { get; set; }

    public string FileNumber { get; set; } = null!;

    public string? FileFrom { get; set; }

    public string? SubmissionDept { get; set; }

    public string? WhomToSubmit { get; set; }

    public string Description { get; set; } = null!;

    public string OtherDetails { get; set; } = null!;

    public byte Status { get; set; }

    public DateTime Date { get; set; }
}
