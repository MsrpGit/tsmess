using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class ProcedureLog1
{
    public DateTime LogDate { get; set; }

    public int? DatabaseId { get; set; }

    public int? ObjectId { get; set; }

    public string? ProcedureName { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public string? AdditionalInfo { get; set; }
}
