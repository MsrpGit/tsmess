using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail4
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public bool IsAdmissionsOpen { get; set; }

    public virtual ICollection<WdiTStudentAcademicDetail4> WdiTStudentAcademicDetail4s { get; set; } = new List<WdiTStudentAcademicDetail4>();
}
