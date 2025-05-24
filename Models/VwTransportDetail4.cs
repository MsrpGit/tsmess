using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class VwTransportDetail4
{
    public string? AdmissionNo { get; set; }

    public string? StudentName { get; set; }

    public string? Class { get; set; }

    public string? Section { get; set; }

    public string? ParentName { get; set; }

    public string? Mobile { get; set; }

    public string? VehicleNo { get; set; }

    public string? RouteName { get; set; }

    public string? RouteType { get; set; }

    public string? Locations { get; set; }

    public string PickupTime { get; set; } = null!;

    public string DropTime { get; set; } = null!;

    public long? PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public decimal? ActualAmount { get; set; }

    public decimal? Concession { get; set; }

    public decimal? PaidAmount { get; set; }

    public decimal? DueAmount { get; set; }

    public string TransportStudent { get; set; } = null!;
}
