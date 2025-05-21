using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBlockMaster
{
    public long BlockId { get; set; }

    public string BlockName { get; set; } = null!;

    /// <summary>
    /// Hostel Id load from Hostel table. etc
    /// </summary>
    public long HostelId { get; set; }

    public long BuildingId { get; set; }

    public string Floor { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
