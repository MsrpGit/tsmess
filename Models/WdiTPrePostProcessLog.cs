using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTPrePostProcessLog
{
    public long PrePostId { get; set; }

    public string SourceMonth { get; set; } = null!;

    public string TargetMonth { get; set; } = null!;

    public bool PreProcess { get; set; }

    public bool PostProcess { get; set; }

    public DateTime PreProcessDate { get; set; }

    public string PreProcessDoneBy { get; set; } = null!;

    public DateTime? PostProcessDate { get; set; }

    public string? PostProcessDoneBy { get; set; }

    public long PartnerId { get; set; }

    public long AcademicYearId { get; set; }
}
