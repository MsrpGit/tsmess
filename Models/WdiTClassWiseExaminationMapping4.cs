using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTClassWiseExaminationMapping4
{
    public long ClassWiseExaminationMappingId { get; set; }

    public int? ClassId { get; set; }

    public string? MasterExamName { get; set; }

    public int? MappedExaminationId { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
