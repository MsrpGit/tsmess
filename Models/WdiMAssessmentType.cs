using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiMAssessmentType
{
    public short ExamId { get; set; }

    public string ExamName { get; set; } = null!;

    public short Term { get; set; }

    public short MaxMarks { get; set; }

    public string Assessment { get; set; } = null!;
}
