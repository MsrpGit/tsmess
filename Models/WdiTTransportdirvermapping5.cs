using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTransportdirvermapping5
{
    public long DriverMappingId { get; set; }

    public long VehicleId { get; set; }

    public string UserId { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool Active { get; set; }

    public long AcademicYearId { get; set; }
}
