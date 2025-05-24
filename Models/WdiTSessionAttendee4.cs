using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTSessionAttendee4
{
    public long AttendeeId { get; set; }

    public string? SessionId { get; set; }

    public string? UserId { get; set; }

    public bool? Status { get; set; }
}
