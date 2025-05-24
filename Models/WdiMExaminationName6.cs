using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMExaminationName6
{
    public long ExaminationId { get; set; }

    public string? ExaminationName { get; set; }

    public long PartnerId { get; set; }

    public long? MainExamId { get; set; }

    public bool? ShowInReport { get; set; }

    public string? AssesmentType { get; set; }

    public decimal? Percentage { get; set; }

    public bool? AssignmentExists { get; set; }

    public int? TermId { get; set; }

    public string? ShortName { get; set; }
}
