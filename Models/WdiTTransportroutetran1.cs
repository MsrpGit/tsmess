using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTransportroutetran1
{
    public long RouteTransId { get; set; }

    public long LocationId { get; set; }

    public decimal OnewayFee { get; set; }

    public decimal TwoWayFee { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool Active { get; set; }

    public long AcademicYearId { get; set; }
}
