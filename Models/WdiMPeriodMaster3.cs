using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPeriodMaster3
{
    public int PeriodMasterIdPk { get; set; }

    public byte? PeriodId { get; set; }

    public string? PeriodShortName { get; set; }

    public string? PeriodStartTime { get; set; }

    public string? PeriodEndTime { get; set; }

    public bool? IsActive { get; set; }

    public int PeriodConfigIdFk { get; set; }

    public int ClassId { get; set; }

    public bool IsPeriod { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int SectionId { get; set; }

    public virtual WdiMAcademicYearDetail3 AcademicYear { get; set; } = null!;

    public virtual WdiMPartner3 Partner { get; set; } = null!;

    public virtual WdiTPeriodConfig3 PeriodConfigIdFkNavigation { get; set; } = null!;
}
