using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTVisitorDetail1
{
    public long VisitorDetailsId { get; set; }

    public long VisitorId { get; set; }

    public string Purpose { get; set; } = null!;

    public string VisitPurpose { get; set; } = null!;

    public string? VehicleDetails { get; set; }

    public string Photo { get; set; } = null!;

    public DateTime VisitedDate { get; set; }

    public byte Status { get; set; }

    public string FurtherActions { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public string? StudentName { get; set; }

    public string? StudentUserid { get; set; }

    public DateTime? OutingValidTill { get; set; }

    public string? ClassandSection { get; set; }
}
