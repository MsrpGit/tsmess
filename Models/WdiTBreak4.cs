using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTBreak4
{
    public int BreakIdPk { get; set; }

    public string? BreakTitle { get; set; }

    public int PeriodConfigIdFk { get; set; }

    public int BreakAfterPeriodId { get; set; }

    public byte BreakDuration { get; set; }

    public bool? IsActive { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? ClassId { get; set; }

    public int SectionId { get; set; }

    public virtual WdiTPeriodConfig4 PeriodConfigIdFkNavigation { get; set; } = null!;
}
