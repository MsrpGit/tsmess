using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail3
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public virtual ICollection<WdiMPeriodMaster3> WdiMPeriodMaster3s { get; set; } = new List<WdiMPeriodMaster3>();

    public virtual ICollection<WdiTStudentAcademicDetail3> WdiTStudentAcademicDetail3s { get; set; } = new List<WdiTStudentAcademicDetail3>();
}
