using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTransportroutevehicle2
{
    public long RvehicleId { get; set; }

    public long RouteId { get; set; }

    public long VehicleId { get; set; }

    public string Createdby { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    /// <summary>
    /// 1 - for Active ; 0 - for In-active
    /// </summary>
    public bool Active { get; set; }

    public long AcademicYearId { get; set; }
}
