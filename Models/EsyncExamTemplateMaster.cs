using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncExamTemplateMaster
{
    public int ExamTemplateId { get; set; }

    public string ExamTemplatename { get; set; } = null!;

    public string? Internalrule { get; set; }

    public decimal Internalmarks { get; set; }

    public string Assignmentrule { get; set; } = null!;

    public decimal Assignmentmarks { get; set; }

    public string Externalrule { get; set; } = null!;

    public decimal Externalmarks { get; set; }

    public decimal Total { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? AcademicYearId { get; set; }

    public long? PartnerId { get; set; }

    public string? BoardType { get; set; }

    public string? DisplayOriginalMarksSubIds { get; set; }

    public bool DisplayInternalAverage { get; set; }

    public bool DisplayExternalAverage { get; set; }

    public bool DisplayAssignmentAverage { get; set; }

    public bool DisplaySubidAvg { get; set; }
}
