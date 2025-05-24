using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemDescription1
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

    public virtual ICollection<WdiMItemPhoto1> WdiMItemPhoto1s { get; set; } = new List<WdiMItemPhoto1>();
}
