using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail5
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public virtual ICollection<WdiMPeriodMaster4> WdiMPeriodMaster4s { get; set; } = new List<WdiMPeriodMaster4>();

    public virtual ICollection<WdiTStudentAcademicDetail5> WdiTStudentAcademicDetail5s { get; set; } = new List<WdiTStudentAcademicDetail5>();
}
