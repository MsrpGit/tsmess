using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMPeriodMaster4
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

    public virtual WdiMAcademicYearDetail5 AcademicYear { get; set; } = null!;

    public virtual WdiMPartner5 Partner { get; set; } = null!;

    public virtual WdiTPeriodConfig4 PeriodConfigIdFkNavigation { get; set; } = null!;
}
