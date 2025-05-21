using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAcademicYearDetail
{
    public long AcademicYearId { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime ToDate { get; set; }

    public long PartnerId { get; set; }

    public bool IsCurrent { get; set; }

    public DateTime ReOpenDate { get; set; }

    public string? Branches { get; set; }

    public bool IsAdmissionsOpen { get; set; }

    public virtual ICollection<WdiMPeriodMaster> WdiMPeriodMasters { get; set; } = new List<WdiMPeriodMaster>();

    public virtual ICollection<WdiTStudentAcademicDetail> WdiTStudentAcademicDetails { get; set; } = new List<WdiTStudentAcademicDetail>();
}
