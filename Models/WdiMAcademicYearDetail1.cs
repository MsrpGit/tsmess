using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail1
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public virtual ICollection<WdiMPeriodMaster1> WdiMPeriodMaster1s { get; set; } = new List<WdiMPeriodMaster1>();

    public virtual ICollection<WdiTStudentAcademicDetail1> WdiTStudentAcademicDetail1s { get; set; } = new List<WdiTStudentAcademicDetail1>();
}
