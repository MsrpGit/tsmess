using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEvent4
{
    public long EventId { get; set; }

    public string EventName { get; set; } = null!;

    public string? UnitNumber { get; set; }

    public string? Venue { get; set; }

    public string? PeriodIds { get; set; }

    public long? ClubId { get; set; }
}
