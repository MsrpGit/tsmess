using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTCcemasterTemplate3
{
    public int ExamId { get; set; }

    public string ExamName { get; set; } = null!;

    public string? AssesmentType { get; set; }

    public int? TermId { get; set; }

    public int? Weightage { get; set; }

    public int? OrderId { get; set; }

    public bool? Cgpa { get; set; }

    public long? PartnerId { get; set; }

    public bool? IsDeleted { get; set; }

    public long? AcademicYearId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? ModifiedBy { get; set; }
}
