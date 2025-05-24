using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail6
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public string? Branches { get; set; }

    public bool IsAdmissionsOpen { get; set; }

    public virtual ICollection<WdiMPeriodMaster5> WdiMPeriodMaster5s { get; set; } = new List<WdiMPeriodMaster5>();

    public virtual ICollection<WdiTStudentAcademicDetail6> WdiTStudentAcademicDetail6s { get; set; } = new List<WdiTStudentAcademicDetail6>();
}
