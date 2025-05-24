using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentHealthDetail4
{
    public int HealthDetailsId { get; set; }

    public string? UserId { get; set; }

    public string? HealthDetails { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
