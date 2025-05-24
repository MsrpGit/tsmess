using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPgstatus5
{
    public int PgstatusId { get; set; }

    public string PgstatusCode { get; set; } = null!;

    public string PgstatusValue { get; set; } = null!;

    public string PaymentGatewayType { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
