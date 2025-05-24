using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMMetricsDetail2
{
    public int Id { get; set; }

    public long PartnerId { get; set; }

    public long Smscount { get; set; }

    public long UsersCount { get; set; }

    public long NewAdmissionsCount { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long EmailCount { get; set; }

    public long PresentSmsCount { get; set; }

    public long PresentUserCount { get; set; }

    public long PresentAdmissionCount { get; set; }

    public long PresentEmailCount { get; set; }

    public byte[]? Remarks { get; set; }
}
