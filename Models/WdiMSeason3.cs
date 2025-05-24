using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMSeason3
{
    public int SeasonId { get; set; }

    public string SeasonName { get; set; } = null!;

    public DateTime FromDate { get; set; }

    public DateTime Todate { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }

    /// <summary>
    /// 1-True, 0-False
    /// </summary>
    public bool? IsActive { get; set; }

    public virtual ICollection<WdiTTimeTableConfig3> WdiTTimeTableConfig3s { get; set; } = new List<WdiTTimeTableConfig3>();
}
