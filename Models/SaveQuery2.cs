using System;
using System.Collections.Generic;

namespace tsmess.Models;

public partial class SaveQuery2
{
    public string? QueryName { get; set; }

    public string? QueryValue { get; set; }

    public string? TableName { get; set; }

    public string? DisplayName { get; set; }

    public long? PartnerId { get; set; }

    public long? AcademicYearId { get; set; }
}
