using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTransportroutemaster
{
    public long RouteId { get; set; }

    public string RouteName { get; set; } = null!;

    public string StartPoint { get; set; } = null!;

    public string? StartPointLongitude { get; set; }

    public string? StartPointLatitude { get; set; }

    public string EndPoint { get; set; } = null!;

    public string? EndPointLongitude { get; set; }

    public string? EndPointLatitude { get; set; }

    public long PartnerId { get; set; }

    public bool Active { get; set; }

    public int? Distance { get; set; }
}
