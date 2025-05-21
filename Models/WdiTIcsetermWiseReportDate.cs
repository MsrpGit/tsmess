using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTIcsetermWiseReportDate
{
    public int Id { get; set; }

    public int ClassId { get; set; }

    public int? SectionId { get; set; }

    public int TermId { get; set; }

    public DateTime? ReportDate { get; set; }

    public int PartnerId { get; set; }

    public int AcademicyearId { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
