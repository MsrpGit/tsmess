using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentAcademicDetail4
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public long ClassId { get; set; }

    public long? Section { get; set; }

    public string RollNo { get; set; } = null!;

    public int GroupId { get; set; }

    public bool Status { get; set; }

    public string? Reason { get; set; }

    public virtual WdiMAcademicYearDetail4 AcademicYear { get; set; } = null!;
}
