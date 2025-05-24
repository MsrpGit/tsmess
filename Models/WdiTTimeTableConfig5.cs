using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTimeTableConfig5
{
    public int TimeTableConfigIdPk { get; set; }

    public int SeasonIdFk { get; set; }

    public bool? IsActive { get; set; }

    public string CreatedById { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedById { get; set; }

    public DateTime? MoidifiedDate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public virtual WdiMSeason6 SeasonIdFkNavigation { get; set; } = null!;

    public virtual ICollection<WdiTPeriodConfig5> WdiTPeriodConfig5s { get; set; } = new List<WdiTPeriodConfig5>();
}
