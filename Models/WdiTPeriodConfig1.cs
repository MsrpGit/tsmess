using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPeriodConfig1
{
    public int PeriodConfigIdPk { get; set; }

    public int TimeTableConfigIdFk { get; set; }

    public byte? NumberOfPeriods { get; set; }

    public string FromDay { get; set; } = null!;

    public string ToDay { get; set; } = null!;

    public string SchoolStartTime { get; set; } = null!;

    public string SchoolEndTime { get; set; } = null!;

    public bool IsFullDay { get; set; }

    public string? LunchDuration { get; set; }

    public int? LunchAfterPeriodId { get; set; }

    public bool? IsActive { get; set; }

    public byte? NumberOfBreaks { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual WdiTTimeTableConfig1 TimeTableConfigIdFkNavigation { get; set; } = null!;

    public virtual ICollection<WdiMPeriodMaster1> WdiMPeriodMaster1s { get; set; } = new List<WdiMPeriodMaster1>();

    public virtual ICollection<WdiTBreak1> WdiTBreak1s { get; set; } = new List<WdiTBreak1>();
}
