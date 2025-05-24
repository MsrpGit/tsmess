using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMScholarshipTypeMaster5
{
    public int ScholarshipId { get; set; }

    public string ScholarshipName { get; set; } = null!;

    public long AcademicyearId { get; set; }

    public long PartnerId { get; set; }

    public string? ShortName { get; set; }
}
