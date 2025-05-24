using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMEvent5
{
    public long EventId { get; set; }

    public long PartnerId { get; set; }

    public string AcademicYearId { get; set; } = null!;

    public int? SemisterId { get; set; }

    public string EventName { get; set; } = null!;

    public long? EventActivityTypeId { get; set; }

    public string? UnitNumber { get; set; }

    public string? Venue { get; set; }

    public string? PeriodIds { get; set; }

    public long? ClubId { get; set; }

    public string EventOrganizerUserId { get; set; } = null!;
}
