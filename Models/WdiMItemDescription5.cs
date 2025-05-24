using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMItemDescription5
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

    public string? NoticeorRemarks { get; set; }

    public bool IsImportantInformation { get; set; }

    public bool IsAnEvent { get; set; }

    public bool IsProcuement { get; set; }

    public DateTime Publishdate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ExtLinks { get; set; }

    public bool IsSpotlight { get; set; }

    public virtual ICollection<WdiMItemPhoto5> WdiMItemPhoto5s { get; set; } = new List<WdiMItemPhoto5>();
}
