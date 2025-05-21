using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPublishDateofBirthStatus
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime? Dob { get; set; }

    public int? ClassId { get; set; }

    public int? SectionId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public int? DobMonth { get; set; }

    public string? SendTo { get; set; }
}
