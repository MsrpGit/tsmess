using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTemplateExamMark
{
    public long TemplateExamMarksId { get; set; }

    public long TemplateMarksId { get; set; }

    public string UserId { get; set; } = null!;

    public long ExaminationId { get; set; }

    public decimal Marks { get; set; }

    public string? MarksFormatted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
