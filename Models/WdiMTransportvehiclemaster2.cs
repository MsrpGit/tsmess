using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMTransportvehiclemaster2
{
    public long VehicleId { get; set; }

    public string RegistrationNumber { get; set; } = null!;

    public string Vname { get; set; } = null!;

    public string? Color { get; set; }

    public string? Model { get; set; }

    public string? DealerAddress { get; set; }

    public DateTime PurchaseDate { get; set; }

    public DateTime WarrantyDate { get; set; }

    public int? Capacity { get; set; }

    public string? Cost { get; set; }

    public string? Mileage { get; set; }

    public string? Permit { get; set; }

    public string? LicenseNumber { get; set; }

    public DateTime PollutionCheckduedate { get; set; }

    public DateTime LicenceRenewalDate { get; set; }

    public string Vtype { get; set; } = null!;

    public bool Active { get; set; }

    public long PartnerId { get; set; }

    public string? VehicleNo { get; set; }
}
