using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail2
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public virtual ICollection<WdiMPeriodMaster2> WdiMPeriodMaster2s { get; set; } = new List<WdiMPeriodMaster2>();

    public virtual ICollection<WdiTStudentAcademicDetail2> WdiTStudentAcademicDetail2s { get; set; } = new List<WdiTStudentAcademicDetail2>();
}
