using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class EsyncExamTemplateConfig
{
    public long Id { get; set; }

    public int? ExamTemplateId { get; set; }

    public long? ClassId { get; set; }

    public long? SectionId { get; set; }

    public int Examinationid { get; set; }

    public string ExaminationType { get; set; } = null!;

    public string IsExamorTemplate { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }

    public string? ExamTemplatename { get; set; }

    public string NoRankOnAbsent { get; set; } = null!;

    public bool DisplayInReport { get; set; }
}
