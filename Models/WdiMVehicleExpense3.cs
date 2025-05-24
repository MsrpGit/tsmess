using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMVehicleExpense3
{
    public int ExpensesId { get; set; }

    public string? VehicleNo { get; set; }

    public DateTime? Createdate { get; set; }

    public string ExpensesType { get; set; } = null!;

    public string? Amount { get; set; }

    public string? CurrentReading { get; set; }

    public string? Remarks { get; set; }

    public string PartnerId { get; set; } = null!;
}
