using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTransportlocationmaster
{
    public long LocationId { get; set; }

    public long RouteId { get; set; }

    public string Locations { get; set; } = null!;

    public string? LocationLongitude { get; set; }

    public string? LocationLatitude { get; set; }

    public int? LocationOrder { get; set; }

    public bool Active { get; set; }

    public decimal? OnewayFare { get; set; }

    public decimal? TwowayFare { get; set; }

    public string? PickupTime { get; set; }

    public string? DropTime { get; set; }
}
