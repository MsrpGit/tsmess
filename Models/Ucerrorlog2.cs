using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class Ucerrorlog2
{
    public int Id { get; set; }

    public string? ErrorNumber { get; set; }

    public string? ErrorSeverity { get; set; }

    public string? ErrorState { get; set; }

    public string? ErrorProcedure { get; set; }

    public string? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? Crateddate { get; set; }
}
