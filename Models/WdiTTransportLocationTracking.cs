using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTransportLocationTracking
{
    public int Id { get; set; }

    public long VehicleId { get; set; }

    public long RouteId { get; set; }

    public string CurrentLongitude { get; set; } = null!;

    public string CurrentLatitude { get; set; } = null!;

    public long PartnerId { get; set; }

    public DateTime Lastupdated { get; set; }

    public string? Updatedby { get; set; }
}
