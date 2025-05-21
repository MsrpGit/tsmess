using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMStreamMaster
{
    public long StreamId { get; set; }

    public string StreamName { get; set; } = null!;

    public string? StreamDescription { get; set; }

    public long PartnerId { get; set; }

    public long AcademicyearId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string ExaminationPassed { get; set; } = null!;

    public bool? Status { get; set; }
}
