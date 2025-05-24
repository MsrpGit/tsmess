using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMStudentFeeDue1
{
    public long StudentDueNo { get; set; }

    public string? UserId { get; set; }

    public long? FeeHeadId { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? DueDate { get; set; }

    public long AcademicYearId { get; set; }
}
