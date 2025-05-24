using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTExamTimeTable5
{
    public long ExaminationId { get; set; }

    public int SchoolId { get; set; }

    public string Examination { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public long AcademicYearId { get; set; }

    public bool? IsCce { get; set; }

    public int? CceexamId { get; set; }

    public long? ExaminationNameId { get; set; }
}
