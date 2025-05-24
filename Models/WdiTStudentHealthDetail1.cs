using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentHealthDetail1
{
    public int HealthDetailsId { get; set; }

    public string? UserId { get; set; }

    public int? TermId { get; set; }

    public int? HeightinCms { get; set; }

    public decimal? Weightinkg { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
