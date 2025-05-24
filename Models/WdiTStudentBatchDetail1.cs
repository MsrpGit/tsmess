using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTStudentBatchDetail1
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AcademicYearId { get; set; }

    public long ClassId { get; set; }

    public string? BatchId { get; set; }

    public long SemisterId { get; set; }

    public long? SectionId { get; set; }
}
