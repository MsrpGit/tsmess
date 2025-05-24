using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPartnerDescriptorsMaster3
{
    public int PartnerDescriptorId { get; set; }

    public string DescriptorName { get; set; } = null!;

    public string? Details { get; set; }

    public long? PartnerId { get; set; }

    public int? MaximumMarks { get; set; }

    public int? FieldId { get; set; }

    public int? OrderId { get; set; }

    public long? AcademicYearId { get; set; }

    public int ClassId { get; set; }

    public int SectionId { get; set; }

    public int SubjectId { get; set; }
}
