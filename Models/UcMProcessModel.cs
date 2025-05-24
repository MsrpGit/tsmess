using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class UcMProcessModel
{
    public long Id { get; set; }

    public long Partnerid { get; set; }

    public long AcademicyearId { get; set; }

    public long ExaminationId { get; set; }

    public long ClassId { get; set; }

    public long SectionId { get; set; }

    public long TermId { get; set; }

    public string RequestType { get; set; } = null!;

    public string RequestValues { get; set; } = null!;

    public byte Status { get; set; }

    public string? LogMessage { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
