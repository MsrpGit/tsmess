using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class WdiTTopStudent3
{
    public long Id { get; set; }

    public long? Partnerid { get; set; }

    public string? Name { get; set; }

    public decimal? Marks { get; set; }

    public string? Rank { get; set; }

    public string? PhotoPath { get; set; }

    public long AcademicYearId { get; set; }

    public string Class { get; set; } = null!;

    public string? Examname { get; set; }
}
