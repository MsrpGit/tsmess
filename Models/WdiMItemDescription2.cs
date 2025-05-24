using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemDescription2
{
    public long ItemId { get; set; }

    public string? ItemTitle { get; set; }

    public string? ItemDescription { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactMobile { get; set; }

    public string? ItemType { get; set; }

    public long? WebsiteId { get; set; }

    public string EventStatus { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public virtual ICollection<WdiMItemPhoto2> WdiMItemPhoto2s { get; set; } = new List<WdiMItemPhoto2>();
}
