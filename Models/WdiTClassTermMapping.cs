using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTClassTermMapping
{
    public long Id { get; set; }

    public long TermId { get; set; }

    public long ClassId { get; set; }

    public long? SectionId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifyBy { get; set; }

    public DateTime? ModifyDate { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }
}
