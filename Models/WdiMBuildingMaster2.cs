using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMBuildingMaster2
{
    public long BuildingId { get; set; }

    public string BuildingName { get; set; } = null!;

    /// <summary>
    /// Hostel Id load from Hostel table. etc
    /// </summary>
    public long HostelId { get; set; }

    public string BuildingWarden { get; set; } = null!;

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
